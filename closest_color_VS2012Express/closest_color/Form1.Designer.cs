namespace closest_color
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.trackBarLuminance = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxRGBHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxRGBInput = new System.Windows.Forms.PictureBox();
            this.dataGridViewColorsHSL = new System.Windows.Forms.DataGridView();
            this.dataGridViewColorsRGB = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLuminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGBInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColorsHSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColorsRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarHue
            // 
            this.trackBarHue.Location = new System.Drawing.Point(392, 30);
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(211, 45);
            this.trackBarHue.TabIndex = 1;
            this.trackBarHue.Value = 5;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarFactor_ValueChanged);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Location = new System.Drawing.Point(392, 78);
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(211, 45);
            this.trackBarSaturation.TabIndex = 1;
            this.trackBarSaturation.Value = 3;
            this.trackBarSaturation.ValueChanged += new System.EventHandler(this.trackBarFactor_ValueChanged);
            // 
            // trackBarLuminance
            // 
            this.trackBarLuminance.Location = new System.Drawing.Point(392, 126);
            this.trackBarLuminance.Name = "trackBarLuminance";
            this.trackBarLuminance.Size = new System.Drawing.Size(211, 45);
            this.trackBarLuminance.TabIndex = 1;
            this.trackBarLuminance.Value = 7;
            this.trackBarLuminance.ValueChanged += new System.EventHandler(this.trackBarFactor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Luminosity";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(29, 56);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(55, 19);
            this.textBoxR.TabIndex = 3;
            this.textBoxR.Text = "0";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(90, 56);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(55, 19);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.Text = "0";
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(151, 56);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(55, 19);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.Text = "0";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            // 
            // textBoxRGBHex
            // 
            this.textBoxRGBHex.Location = new System.Drawing.Point(29, 81);
            this.textBoxRGBHex.Name = "textBoxRGBHex";
            this.textBoxRGBHex.Size = new System.Drawing.Size(177, 19);
            this.textBoxRGBHex.TabIndex = 3;
            this.textBoxRGBHex.Text = "#000000";
            this.textBoxRGBHex.TextChanged += new System.EventHandler(this.textBoxRGBHex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "B";
            // 
            // pictureBoxRGBInput
            // 
            this.pictureBoxRGBInput.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRGBInput.Location = new System.Drawing.Point(29, 117);
            this.pictureBoxRGBInput.Name = "pictureBoxRGBInput";
            this.pictureBoxRGBInput.Size = new System.Drawing.Size(177, 50);
            this.pictureBoxRGBInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRGBInput.TabIndex = 1;
            this.pictureBoxRGBInput.TabStop = false;
            // 
            // dataGridViewColorsHSL
            // 
            this.dataGridViewColorsHSL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewColorsHSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColorsHSL.Location = new System.Drawing.Point(392, 217);
            this.dataGridViewColorsHSL.Name = "dataGridViewColorsHSL";
            this.dataGridViewColorsHSL.RowTemplate.Height = 21;
            this.dataGridViewColorsHSL.Size = new System.Drawing.Size(344, 150);
            this.dataGridViewColorsHSL.TabIndex = 6;
            // 
            // dataGridViewColorsRGB
            // 
            this.dataGridViewColorsRGB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewColorsRGB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColorsRGB.Location = new System.Drawing.Point(29, 217);
            this.dataGridViewColorsRGB.Name = "dataGridViewColorsRGB";
            this.dataGridViewColorsRGB.RowTemplate.Height = 21;
            this.dataGridViewColorsRGB.Size = new System.Drawing.Size(344, 150);
            this.dataGridViewColorsRGB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "RGB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hue, Saturation and Luminosity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 379);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewColorsRGB);
            this.Controls.Add(this.dataGridViewColorsHSL);
            this.Controls.Add(this.pictureBoxRGBInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxRGBHex);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarLuminance);
            this.Controls.Add(this.trackBarSaturation);
            this.Controls.Add(this.trackBarHue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLuminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGBInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColorsHSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColorsRGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarLuminance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxRGBHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxRGBInput;
        private System.Windows.Forms.DataGridView dataGridViewColorsHSL;
        private System.Windows.Forms.DataGridView dataGridViewColorsRGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

