﻿namespace QRBarcode
{
    partial class FormChoose
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCreate = new System.Windows.Forms.Button();
            this.BRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BCreate
            // 
            this.BCreate.Location = new System.Drawing.Point(12, 12);
            this.BCreate.Name = "BCreate";
            this.BCreate.Size = new System.Drawing.Size(126, 49);
            this.BCreate.TabIndex = 0;
            this.BCreate.Text = "Создание кода";
            this.BCreate.UseVisualStyleBackColor = true;
            this.BCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // BRead
            // 
            this.BRead.Location = new System.Drawing.Point(144, 12);
            this.BRead.Name = "BRead";
            this.BRead.Size = new System.Drawing.Size(126, 49);
            this.BRead.TabIndex = 1;
            this.BRead.Text = "Чтение кода";
            this.BRead.UseVisualStyleBackColor = true;
            this.BRead.Click += new System.EventHandler(this.BRead_Click);
            // 
            // Formchoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 73);
            this.Controls.Add(this.BRead);
            this.Controls.Add(this.BCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Formchoose";
            this.Text = "C/R-code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BCreate;
        private System.Windows.Forms.Button BRead;
    }
}
