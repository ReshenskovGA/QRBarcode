namespace QRBarcode
{
    partial class FormCreateCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BGenerate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gBBar = new System.Windows.Forms.GroupBox();
            this.CBEncoding = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gBQR = new System.Windows.Forms.GroupBox();
            this.textBQRVer = new System.Windows.Forms.TextBox();
            this.trackBQRVer = new System.Windows.Forms.TrackBar();
            this.cBErrorCor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBSizeQR = new System.Windows.Forms.TextBox();
            this.BsPrev = new System.Windows.Forms.Button();
            this.CBColor = new System.Windows.Forms.CheckBox();
            this.BColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBExtension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBar = new System.Windows.Forms.CheckBox();
            this.CheckQR = new System.Windows.Forms.CheckBox();
            this.BSave = new System.Windows.Forms.Button();
            this.BPath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gBBar.SuspendLayout();
            this.gBQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBQRVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // BGenerate
            // 
            this.BGenerate.Location = new System.Drawing.Point(179, 324);
            this.BGenerate.Name = "BGenerate";
            this.BGenerate.Size = new System.Drawing.Size(130, 23);
            this.BGenerate.TabIndex = 1;
            this.BGenerate.Text = "Сгенерировать";
            this.BGenerate.UseVisualStyleBackColor = true;
            this.BGenerate.Click += new System.EventHandler(this.BGenerate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gBBar);
            this.splitContainer1.Panel1.Controls.Add(this.gBQR);
            this.splitContainer1.Panel1.Controls.Add(this.BsPrev);
            this.splitContainer1.Panel1.Controls.Add(this.CBColor);
            this.splitContainer1.Panel1.Controls.Add(this.BColor);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CBExtension);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CheckBar);
            this.splitContainer1.Panel1.Controls.Add(this.CheckQR);
            this.splitContainer1.Panel1.Controls.Add(this.BSave);
            this.splitContainer1.Panel1.Controls.Add(this.BPath);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.TBPath);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.TBName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.TBText);
            this.splitContainer1.Panel1.Controls.Add(this.BGenerate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(966, 501);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 7;
            // 
            // gBBar
            // 
            this.gBBar.Controls.Add(this.CBEncoding);
            this.gBBar.Controls.Add(this.label11);
            this.gBBar.Enabled = false;
            this.gBBar.Location = new System.Drawing.Point(2, 147);
            this.gBBar.Name = "gBBar";
            this.gBBar.Size = new System.Drawing.Size(316, 114);
            this.gBBar.TabIndex = 2;
            this.gBBar.TabStop = false;
            this.gBBar.Visible = false;
            // 
            // CBEncoding
            // 
            this.CBEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEncoding.FormattingEnabled = true;
            this.CBEncoding.Items.AddRange(new object[] {
            "Aztec",
            "Code128",
            "Code39",
            "Code93",
            "DataMatrix",
            "PDF417"});
            this.CBEncoding.Location = new System.Drawing.Point(14, 27);
            this.CBEncoding.Name = "CBEncoding";
            this.CBEncoding.Size = new System.Drawing.Size(147, 24);
            this.CBEncoding.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Кодировака";
            // 
            // gBQR
            // 
            this.gBQR.Controls.Add(this.textBQRVer);
            this.gBQR.Controls.Add(this.trackBQRVer);
            this.gBQR.Controls.Add(this.cBErrorCor);
            this.gBQR.Controls.Add(this.label8);
            this.gBQR.Controls.Add(this.label7);
            this.gBQR.Controls.Add(this.label5);
            this.gBQR.Controls.Add(this.tBSizeQR);
            this.gBQR.Enabled = false;
            this.gBQR.Location = new System.Drawing.Point(6, 141);
            this.gBQR.Name = "gBQR";
            this.gBQR.Size = new System.Drawing.Size(316, 119);
            this.gBQR.TabIndex = 31;
            this.gBQR.TabStop = false;
            this.gBQR.Visible = false;
            // 
            // textBQRVer
            // 
            this.textBQRVer.Location = new System.Drawing.Point(173, 30);
            this.textBQRVer.Name = "textBQRVer";
            this.textBQRVer.Size = new System.Drawing.Size(61, 22);
            this.textBQRVer.TabIndex = 6;
            this.textBQRVer.Text = "1";
            this.textBQRVer.TextChanged += new System.EventHandler(this.TextBQRVer_TextChanged);
            this.textBQRVer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBQRVer_KeyPress);
            // 
            // trackBQRVer
            // 
            this.trackBQRVer.Location = new System.Drawing.Point(159, 58);
            this.trackBQRVer.Maximum = 40;
            this.trackBQRVer.Minimum = 1;
            this.trackBQRVer.Name = "trackBQRVer";
            this.trackBQRVer.Size = new System.Drawing.Size(151, 56);
            this.trackBQRVer.TabIndex = 5;
            this.trackBQRVer.Value = 1;
            this.trackBQRVer.Scroll += new System.EventHandler(this.TrackBQRVer_Scroll);
            // 
            // cBErrorCor
            // 
            this.cBErrorCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBErrorCor.FormattingEnabled = true;
            this.cBErrorCor.Items.AddRange(new object[] {
            "Высочайший",
            "Высокий",
            "Средний",
            "Низкий"});
            this.cBErrorCor.Location = new System.Drawing.Point(6, 78);
            this.cBErrorCor.Name = "cBErrorCor";
            this.cBErrorCor.Size = new System.Drawing.Size(133, 24);
            this.cBErrorCor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Уровень коррекции";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Версия QR кода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Размер кода";
            // 
            // tBSizeQR
            // 
            this.tBSizeQR.Location = new System.Drawing.Point(6, 33);
            this.tBSizeQR.Name = "tBSizeQR";
            this.tBSizeQR.Size = new System.Drawing.Size(100, 22);
            this.tBSizeQR.TabIndex = 0;
            this.tBSizeQR.Text = "500";
            this.tBSizeQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSizeQR_KeyPress);
            // 
            // BsPrev
            // 
            this.BsPrev.Location = new System.Drawing.Point(13, 472);
            this.BsPrev.Name = "BsPrev";
            this.BsPrev.Size = new System.Drawing.Size(193, 23);
            this.BsPrev.TabIndex = 30;
            this.BsPrev.Text = "Вернуться к выбору";
            this.BsPrev.UseVisualStyleBackColor = true;
            this.BsPrev.Click += new System.EventHandler(this.BPrev_Click);
            // 
            // CBColor
            // 
            this.CBColor.AutoSize = true;
            this.CBColor.Location = new System.Drawing.Point(6, 99);
            this.CBColor.Name = "CBColor";
            this.CBColor.Size = new System.Drawing.Size(200, 36);
            this.CBColor.TabIndex = 27;
            this.CBColor.Text = "Использовать выбранный\r\n цвет";
            this.CBColor.UseVisualStyleBackColor = true;
            this.CBColor.CheckedChanged += new System.EventHandler(this.CBColor_CheckedChanged);
            // 
            // BColor
            // 
            this.BColor.Enabled = false;
            this.BColor.Location = new System.Drawing.Point(235, 99);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(83, 42);
            this.BColor.TabIndex = 26;
            this.BColor.Text = "Выбрать цвет";
            this.BColor.UseVisualStyleBackColor = true;
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Формат расширения файла";
            // 
            // CBExtension
            // 
            this.CBExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBExtension.FormattingEnabled = true;
            this.CBExtension.Items.AddRange(new object[] {
            ".png",
            ".pdf",
            ".jpeg",
            ".jpg",
            ".gif",
            ".html",
            ".tiff",
            ".bmp"});
            this.CBExtension.Location = new System.Drawing.Point(6, 441);
            this.CBExtension.Name = "CBExtension";
            this.CBExtension.Size = new System.Drawing.Size(75, 24);
            this.CBExtension.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Выберите формат кода";
            // 
            // CheckBar
            // 
            this.CheckBar.AutoSize = true;
            this.CheckBar.Location = new System.Drawing.Point(86, 73);
            this.CheckBar.Name = "CheckBar";
            this.CheckBar.Size = new System.Drawing.Size(50, 20);
            this.CheckBar.TabIndex = 22;
            this.CheckBar.Text = "Bar";
            this.CheckBar.UseVisualStyleBackColor = true;
            this.CheckBar.CheckedChanged += new System.EventHandler(this.CheckBar_CheckedChanged);
            // 
            // CheckQR
            // 
            this.CheckQR.AutoSize = true;
            this.CheckQR.Location = new System.Drawing.Point(6, 73);
            this.CheckQR.Name = "CheckQR";
            this.CheckQR.Size = new System.Drawing.Size(49, 20);
            this.CheckQR.TabIndex = 21;
            this.CheckQR.Text = "QR";
            this.CheckQR.UseVisualStyleBackColor = true;
            this.CheckQR.CheckedChanged += new System.EventHandler(this.CheckQR_CheckedChanged);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(184, 442);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(125, 23);
            this.BSave.TabIndex = 18;
            this.BSave.Text = "Сохранить файл";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BPath
            // 
            this.BPath.Location = new System.Drawing.Point(247, 397);
            this.BPath.Name = "BPath";
            this.BPath.Size = new System.Drawing.Size(62, 23);
            this.BPath.TabIndex = 17;
            this.BPath.Text = "Обзор";
            this.BPath.UseVisualStyleBackColor = true;
            this.BPath.Click += new System.EventHandler(this.BPath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Путь сохоанения файла";
            // 
            // TBPath
            // 
            this.TBPath.Location = new System.Drawing.Point(6, 397);
            this.TBPath.Name = "TBPath";
            this.TBPath.Size = new System.Drawing.Size(234, 22);
            this.TBPath.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Названия файла";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(6, 353);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(257, 22);
            this.TBName.TabIndex = 11;
            this.TBName.Text = "MyCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите текст для кодировки";
            // 
            // TBText
            // 
            this.TBText.Location = new System.Drawing.Point(6, 29);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(257, 22);
            this.TBText.TabIndex = 2;
            this.TBText.Text = "Hello world";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FormCreateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 514);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCreateCode";
            this.Text = "Создание кода";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gBBar.ResumeLayout(false);
            this.gBBar.PerformLayout();
            this.gBQR.ResumeLayout(false);
            this.gBQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBQRVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BGenerate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BPath;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.CheckBox CheckQR;
        private System.Windows.Forms.CheckBox CheckBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox CBColor;
        private System.Windows.Forms.Button BsPrev;
        private System.Windows.Forms.GroupBox gBQR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBSizeQR;
        private System.Windows.Forms.TrackBar trackBQRVer;
        private System.Windows.Forms.ComboBox cBErrorCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox textBQRVer;
        private System.Windows.Forms.GroupBox gBBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBEncoding;
    }
}