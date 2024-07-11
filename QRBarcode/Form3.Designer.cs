namespace BarcodeTest
{
    partial class Form3
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bSelectFile = new System.Windows.Forms.Button();
            this.bReadFile = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tBFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.bPrev = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bSelectFile
            // 
            this.bSelectFile.Location = new System.Drawing.Point(6, 55);
            this.bSelectFile.Name = "bSelectFile";
            this.bSelectFile.Size = new System.Drawing.Size(116, 23);
            this.bSelectFile.TabIndex = 0;
            this.bSelectFile.Text = "Выбор файла";
            this.bSelectFile.UseVisualStyleBackColor = true;
            this.bSelectFile.Click += new System.EventHandler(this.bSelectFile_Click);
            // 
            // bReadFile
            // 
            this.bReadFile.Location = new System.Drawing.Point(12, 155);
            this.bReadFile.Name = "bReadFile";
            this.bReadFile.Size = new System.Drawing.Size(130, 33);
            this.bReadFile.TabIndex = 1;
            this.bReadFile.Text = "Чтение файла";
            this.bReadFile.UseVisualStyleBackColor = true;
            this.bReadFile.Click += new System.EventHandler(this.bReadFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bPrev);
            this.splitContainer1.Panel1.Controls.Add(this.tBFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bSelectFile);
            this.splitContainer1.Panel1.Controls.Add(this.bReadFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rTB);
            this.splitContainer1.Size = new System.Drawing.Size(628, 228);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 2;
            // 
            // tBFilePath
            // 
            this.tBFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBFilePath.Location = new System.Drawing.Point(4, 27);
            this.tBFilePath.Name = "tBFilePath";
            this.tBFilePath.Size = new System.Drawing.Size(239, 22);
            this.tBFilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу";
            // 
            // rTB
            // 
            this.rTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB.Location = new System.Drawing.Point(3, 3);
            this.rTB.Name = "rTB";
            this.rTB.ReadOnly = true;
            this.rTB.Size = new System.Drawing.Size(372, 222);
            this.rTB.TabIndex = 2;
            this.rTB.Text = "";
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(13, 195);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(157, 23);
            this.bPrev.TabIndex = 4;
            this.bPrev.Text = "Вернуться к выбору";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 231);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Чтение кода";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bSelectFile;
        private System.Windows.Forms.Button bReadFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.TextBox tBFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPrev;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}