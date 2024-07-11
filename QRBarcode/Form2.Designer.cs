namespace BarcodeTest
{
    partial class Form2
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
            this.bGenerate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gBBar = new System.Windows.Forms.GroupBox();
            this.cBEncoding = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gBQR = new System.Windows.Forms.GroupBox();
            this.textBQRVer = new System.Windows.Forms.TextBox();
            this.trackBQRVer = new System.Windows.Forms.TrackBar();
            this.cBErrorCor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBSizeQR = new System.Windows.Forms.TextBox();
            this.bPrev = new System.Windows.Forms.Button();
            this.cBColor = new System.Windows.Forms.CheckBox();
            this.bColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBExtension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBar = new System.Windows.Forms.CheckBox();
            this.checkQR = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bPath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBText = new System.Windows.Forms.TextBox();
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
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(179, 324);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(130, 23);
            this.bGenerate.TabIndex = 1;
            this.bGenerate.Text = "Сгенерировать";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.bPrev);
            this.splitContainer1.Panel1.Controls.Add(this.cBColor);
            this.splitContainer1.Panel1.Controls.Add(this.bColor);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cBExtension);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBar);
            this.splitContainer1.Panel1.Controls.Add(this.checkQR);
            this.splitContainer1.Panel1.Controls.Add(this.bSave);
            this.splitContainer1.Panel1.Controls.Add(this.bPath);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tBPath);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tBName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tBText);
            this.splitContainer1.Panel1.Controls.Add(this.bGenerate);
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
            this.gBBar.Controls.Add(this.cBEncoding);
            this.gBBar.Controls.Add(this.label11);
            this.gBBar.Enabled = false;
            this.gBBar.Location = new System.Drawing.Point(2, 147);
            this.gBBar.Name = "gBBar";
            this.gBBar.Size = new System.Drawing.Size(316, 114);
            this.gBBar.TabIndex = 2;
            this.gBBar.TabStop = false;
            this.gBBar.Visible = false;
            // 
            // cBEncoding
            // 
            this.cBEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEncoding.FormattingEnabled = true;
            this.cBEncoding.Items.AddRange(new object[] {
            "Aztec",
            "Code128",
            "Code39",
            "Code93",
            "DataMatrix",
            "PDF417"});
            this.cBEncoding.Location = new System.Drawing.Point(14, 27);
            this.cBEncoding.Name = "cBEncoding";
            this.cBEncoding.Size = new System.Drawing.Size(147, 24);
            this.cBEncoding.TabIndex = 5;
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
            this.textBQRVer.TextChanged += new System.EventHandler(this.textBQRVer_TextChanged);
            this.textBQRVer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBQRVer_KeyPress);
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
            this.trackBQRVer.Scroll += new System.EventHandler(this.trackBQRVer_Scroll);
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
            this.tBSizeQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBSizeQR_KeyPress);
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(13, 472);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(193, 23);
            this.bPrev.TabIndex = 30;
            this.bPrev.Text = "Вернуться к выбору";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // cBColor
            // 
            this.cBColor.AutoSize = true;
            this.cBColor.Location = new System.Drawing.Point(6, 99);
            this.cBColor.Name = "cBColor";
            this.cBColor.Size = new System.Drawing.Size(200, 36);
            this.cBColor.TabIndex = 27;
            this.cBColor.Text = "Использовать выбранный\r\n цвет";
            this.cBColor.UseVisualStyleBackColor = true;
            this.cBColor.CheckedChanged += new System.EventHandler(this.cBColor_CheckedChanged);
            // 
            // bColor
            // 
            this.bColor.Enabled = false;
            this.bColor.Location = new System.Drawing.Point(235, 99);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(83, 42);
            this.bColor.TabIndex = 26;
            this.bColor.Text = "Выбрать цвет";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
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
            // cBExtension
            // 
            this.cBExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBExtension.FormattingEnabled = true;
            this.cBExtension.Items.AddRange(new object[] {
            ".png",
            ".pdf",
            ".jpeg",
            ".jpg",
            ".gif",
            ".html",
            ".tiff",
            ".bmp"});
            this.cBExtension.Location = new System.Drawing.Point(6, 441);
            this.cBExtension.Name = "cBExtension";
            this.cBExtension.Size = new System.Drawing.Size(75, 24);
            this.cBExtension.TabIndex = 24;
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
            // checkBar
            // 
            this.checkBar.AutoSize = true;
            this.checkBar.Location = new System.Drawing.Point(86, 73);
            this.checkBar.Name = "checkBar";
            this.checkBar.Size = new System.Drawing.Size(50, 20);
            this.checkBar.TabIndex = 22;
            this.checkBar.Text = "Bar";
            this.checkBar.UseVisualStyleBackColor = true;
            this.checkBar.CheckedChanged += new System.EventHandler(this.checkBar_CheckedChanged);
            // 
            // checkQR
            // 
            this.checkQR.AutoSize = true;
            this.checkQR.Location = new System.Drawing.Point(6, 73);
            this.checkQR.Name = "checkQR";
            this.checkQR.Size = new System.Drawing.Size(49, 20);
            this.checkQR.TabIndex = 21;
            this.checkQR.Text = "QR";
            this.checkQR.UseVisualStyleBackColor = true;
            this.checkQR.CheckedChanged += new System.EventHandler(this.checkQR_CheckedChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(184, 442);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(125, 23);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Сохранить файл";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bPath
            // 
            this.bPath.Location = new System.Drawing.Point(247, 397);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(62, 23);
            this.bPath.TabIndex = 17;
            this.bPath.Text = "Обзор";
            this.bPath.UseVisualStyleBackColor = true;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
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
            // tBPath
            // 
            this.tBPath.Location = new System.Drawing.Point(6, 397);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(234, 22);
            this.tBPath.TabIndex = 14;
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
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(6, 353);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(257, 22);
            this.tBName.TabIndex = 11;
            this.tBName.Text = "MyCode";
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
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(6, 29);
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(257, 22);
            this.tBText.TabIndex = 2;
            this.tBText.Text = "Hello world";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 514);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
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
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bPath;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox checkQR;
        private System.Windows.Forms.CheckBox checkBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cBColor;
        private System.Windows.Forms.Button bPrev;
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
        private System.Windows.Forms.ComboBox cBEncoding;
    }
}