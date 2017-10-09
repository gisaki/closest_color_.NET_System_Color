using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace closest_color
{
    public partial class Form1 : Form
    {
        private Color target_color_ = Color.Black;
        ClosestColor cc_ = null;
        List<Color> colors_base_;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cc_ = new ClosestColor();
            cc_.factorHue_ = ((float)trackBarHue.Value) / trackBarHue.Maximum;
            cc_.factorSat_ = ((float)trackBarSaturation.Value) / trackBarSaturation.Maximum;
            cc_.factorLum_ = ((float)trackBarLuminance.Value) / trackBarLuminance.Maximum;

            initColorsList(ref dataGridViewColorsRGB);
            initColorsList(ref dataGridViewColorsHSL);

            updateColorsListRGB(target_color_, ref dataGridViewColorsRGB);
            updateColorsListHSL(target_color_, ref dataGridViewColorsHSL);
        }

        // 
        // 設定値更新
        // 
        private void textBoxRGB_TextChanged(object sender, EventArgs e)
        {
            // 設定値変更
            {
                int rgb_r = 0;
                int rgb_g = 0;
                int rgb_b = 0;

                Int32.TryParse(textBoxR.Text, out rgb_r);
                Int32.TryParse(textBoxG.Text, out rgb_g);
                Int32.TryParse(textBoxB.Text, out rgb_b);

                rgb_r = System.Math.Min(System.Math.Max(0, rgb_r), 255);
                rgb_g = System.Math.Min(System.Math.Max(0, rgb_g), 255);
                rgb_b = System.Math.Min(System.Math.Max(0, rgb_b), 255);

                target_color_ = Color.FromArgb(255, rgb_r, rgb_g, rgb_b);
            }
            drawRBGRec(target_color_, ref pictureBoxRGBInput);

            // 表示更新
            updateColorsListRGB(target_color_, ref dataGridViewColorsRGB);
            updateColorsListHSL(target_color_, ref dataGridViewColorsHSL);

            // 相手側
            textBoxRGBHex.Text = "#" + target_color_.R.ToString("X2") + target_color_.G.ToString("X2") + target_color_.B.ToString("X2");
        }
        private void textBoxRGBHex_TextChanged(object sender, EventArgs e)
        {
            // 設定値変更
            if (
                (textBoxRGBHex.Text[0] != '#')
                || (textBoxRGBHex.Text.Length != 7)
            )
            {
                // 入力途中なので何もせず終了
                return;
            }
            try
            {
                target_color_ = ColorTranslator.FromHtml(textBoxRGBHex.Text);
            }
            catch (Exception ex)
            {
                // 入力途中なので何もせず終了
                return;
            }
            drawRBGRec(target_color_, ref pictureBoxRGBInput);

            // 表示更新
            updateColorsListRGB(target_color_, ref dataGridViewColorsRGB);
            updateColorsListHSL(target_color_, ref dataGridViewColorsHSL);

            // 相手側
            textBoxR.Text = target_color_.R.ToString();
            textBoxG.Text = target_color_.G.ToString();
            textBoxB.Text = target_color_.B.ToString();
        }

        private void trackBarFactor_ValueChanged(object sender, EventArgs e)
        {
            if (cc_ == null)
            {
                return;
            }

            // 設定値変更
            cc_.factorHue_ = ((float)trackBarHue.Value) / trackBarHue.Maximum;
            cc_.factorSat_ = ((float)trackBarSaturation.Value) / trackBarSaturation.Maximum;
            cc_.factorLum_ = ((float)trackBarLuminance.Value) / trackBarLuminance.Maximum;

            // 表示更新
            updateColorsListRGB(target_color_, ref dataGridViewColorsRGB);
            updateColorsListHSL(target_color_, ref dataGridViewColorsHSL);
        }

        // 
        // 描画更新
        // 
        Bitmap image1;
        private void drawRBGRec(Color target, ref PictureBox picture_box)
        {

            // Retrieve the image.
            image1 = new Bitmap(picture_box.Width, picture_box.Height);

            int x, y;

            // Loop through the images pixels to reset color.
            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    Color newColor = target;
                    image1.SetPixel(x, y, newColor);
                }
            }

            // Set the PictureBox to display the image.
            picture_box.Image = image1; 
            
            return;
        }

        private void initColorsList(ref DataGridView view)
        {
            colors_base_ = typeof(Color).GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
                .Select(p => Color.FromName(p.Name))
                .ToList();
            view.DataSource = colors_base_;

            // 表示
            foreach (DataGridViewColumn col in view.Columns)
            {
                if (!(col.Name == "R" || col.Name == "G" || col.Name == "B" || col.Name == "Name"))
                {
                    col.Visible = false;
                }
            }
            view.Columns["Name"].DisplayIndex = 0;
        }
        private void updateColorsListRGB(Color target, ref DataGridView view)
        {
            List<Color> colors = new List<Color>(colors_base_);
            // ソート
            cc_.sortClosestColorRGB(ref colors, target);

            view.DataSource = colors;
            for (int i = 0; i < colors.Count; ++i)
            {
                view["Name", i].Style.BackColor = colors[i];
            }
        }
        private void updateColorsListHSL(Color target, ref DataGridView view)
        {
            List<Color> colors = new List<Color>(colors_base_);
            // ソート
            cc_.sortClosestColorHSL(ref colors, target);

            view.DataSource = colors;
            for (int i = 0; i < colors.Count; ++i)
            {
                view["Name", i].Style.BackColor = colors[i];
            }
        }

    }
}
