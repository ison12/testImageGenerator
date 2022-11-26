namespace TestImageGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoFileTypeJpeg = new System.Windows.Forms.RadioButton();
            this.rdoFileTypePng = new System.Windows.Forms.RadioButton();
            this.rdoFileTypeBmp = new System.Windows.Forms.RadioButton();
            this.rdoFileTypeGif = new System.Windows.Forms.RadioButton();
            this.rdoFileTypeTiff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutputDirPath
            // 
            this.txtOutputDirPath.Location = new System.Drawing.Point(118, 48);
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.Size = new System.Drawing.Size(670, 23);
            this.txtOutputDirPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "出力ディレクトリパス";
            // 
            // txtWidth
            // 
            this.txtWidth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWidth.Location = new System.Drawing.Point(141, 82);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(76, 23);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "300";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHeight.Location = new System.Drawing.Point(269, 82);
            this.txtHeight.MaxLength = 4;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(76, 23);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Text = "300";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "解像度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "×";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(550, 477);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(116, 32);
            this.btnExecute.TabIndex = 12;
            this.btnExecute.Text = "実行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(374, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ファイル種類";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "テスト用画像を任意のファイル名で生成するツール";
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(12, 150);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFiles.Size = new System.Drawing.Size(776, 321);
            this.txtFiles.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "生成するファイル名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(539, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "例えば、0001.jpgやABCD.jpgを2ファイル作成したければ、以下に\"0001.jpg(改行)ABCD.jpg\"と入力してください。";
            // 
            // rdoFileTypeJpeg
            // 
            this.rdoFileTypeJpeg.AutoSize = true;
            this.rdoFileTypeJpeg.Checked = true;
            this.rdoFileTypeJpeg.Location = new System.Drawing.Point(14, 12);
            this.rdoFileTypeJpeg.Name = "rdoFileTypeJpeg";
            this.rdoFileTypeJpeg.Size = new System.Drawing.Size(50, 19);
            this.rdoFileTypeJpeg.TabIndex = 0;
            this.rdoFileTypeJpeg.TabStop = true;
            this.rdoFileTypeJpeg.Text = "JPEG";
            this.rdoFileTypeJpeg.UseVisualStyleBackColor = true;
            // 
            // rdoFileTypePng
            // 
            this.rdoFileTypePng.AutoSize = true;
            this.rdoFileTypePng.Location = new System.Drawing.Point(70, 12);
            this.rdoFileTypePng.Name = "rdoFileTypePng";
            this.rdoFileTypePng.Size = new System.Drawing.Size(49, 19);
            this.rdoFileTypePng.TabIndex = 1;
            this.rdoFileTypePng.Text = "PNG";
            this.rdoFileTypePng.UseVisualStyleBackColor = true;
            // 
            // rdoFileTypeBmp
            // 
            this.rdoFileTypeBmp.AutoSize = true;
            this.rdoFileTypeBmp.Location = new System.Drawing.Point(173, 12);
            this.rdoFileTypeBmp.Name = "rdoFileTypeBmp";
            this.rdoFileTypeBmp.Size = new System.Drawing.Size(50, 19);
            this.rdoFileTypeBmp.TabIndex = 3;
            this.rdoFileTypeBmp.Text = "BMP";
            this.rdoFileTypeBmp.UseVisualStyleBackColor = true;
            // 
            // rdoFileTypeGif
            // 
            this.rdoFileTypeGif.AutoSize = true;
            this.rdoFileTypeGif.Location = new System.Drawing.Point(125, 12);
            this.rdoFileTypeGif.Name = "rdoFileTypeGif";
            this.rdoFileTypeGif.Size = new System.Drawing.Size(42, 19);
            this.rdoFileTypeGif.TabIndex = 2;
            this.rdoFileTypeGif.Text = "GIF";
            this.rdoFileTypeGif.UseVisualStyleBackColor = true;
            // 
            // rdoFileTypeTiff
            // 
            this.rdoFileTypeTiff.AutoSize = true;
            this.rdoFileTypeTiff.Location = new System.Drawing.Point(229, 12);
            this.rdoFileTypeTiff.Name = "rdoFileTypeTiff";
            this.rdoFileTypeTiff.Size = new System.Drawing.Size(46, 19);
            this.rdoFileTypeTiff.TabIndex = 4;
            this.rdoFileTypeTiff.Text = "TIFF";
            this.rdoFileTypeTiff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoFileTypeBmp);
            this.groupBox1.Controls.Add(this.rdoFileTypeTiff);
            this.groupBox1.Controls.Add(this.rdoFileTypeJpeg);
            this.groupBox1.Controls.Add(this.rdoFileTypeGif);
            this.groupBox1.Controls.Add(this.rdoFileTypePng);
            this.groupBox1.Location = new System.Drawing.Point(443, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(291, 34);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "幅";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "高";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputDirPath);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Test Image Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOutputDirPath;
        private Label label1;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Label label2;
        private Label label3;
        private Button btnExecute;
        private Label label4;
        private Button btnClose;
        private Label label6;
        private TextBox txtFiles;
        private Label label7;
        private Label label8;
        private RadioButton rdoFileTypeJpeg;
        private RadioButton rdoFileTypePng;
        private RadioButton rdoFileTypeBmp;
        private RadioButton rdoFileTypeGif;
        private RadioButton rdoFileTypeTiff;
        private GroupBox groupBox1;
        private Label label5;
        private Label label9;
    }
}