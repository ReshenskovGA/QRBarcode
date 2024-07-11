using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace BarcodeTest
{
    public partial class Form2 : Form
    {
        private string[] extension = { ".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".bmp" };
        private string[] strCorLev = {"Высочайший", "Высокий", "Средний", "Низкий"};
        private string[] encodind = {"Aztec", "Code128", "Code39", "Code93", "DataMatrix", "PDF417"};
        private GeneratedBarcode Code;
        private string codePath;
        private string folderPath = @"SaveCodes/";
        private int numCode = 0;

        public Form2()
        {
            InitializeComponent();
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.SolidColorOnly = true;
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        
        private void bGenerate_Click(object sender, EventArgs e)
        {
            
            if (Check(sender) == false)
            {
                try
                {
                    if (checkQR.Checked || checkBar.Checked)
                    {
                        numCode++;
                        codePath = folderPath + numCode + ".png";
                        var text = tBText.Text;
                        if (checkQR.Checked)
                        {
                            QRCodeWriter.QrErrorCorrectionLevel correction;
                            //"Высочайший", "Высокий", "Средний", "Низкий"
                            switch (Array.IndexOf(strCorLev, cBErrorCor.Text))
                            {
                                case 0:
                                    correction = QRCodeWriter.QrErrorCorrectionLevel.Highest;
                                    break;
                                case 2:
                                    correction = QRCodeWriter.QrErrorCorrectionLevel.Medium;
                                    break;
                                case 3:
                                    correction = QRCodeWriter.QrErrorCorrectionLevel.Low;
                                    break;
                                default:
                                    correction = QRCodeWriter.QrErrorCorrectionLevel.High;
                                    break;
                            }
                            if (String.IsNullOrEmpty(tBSizeQR.Text))
                                tBSizeQR.Text = "500";
                            if (String.IsNullOrEmpty(textBQRVer.Text))
                                textBQRVer.Text = "1";
                            var size = Convert.ToInt32(tBSizeQR.Text);
                            var verQR = Convert.ToInt32(textBQRVer.Text);
                            Code = QRCodeWriter.CreateQrCode(text, size, correction, verQR);
                            Color(sender);
                            Code.SaveAsPng(codePath);
                            pictureBox1.Image = Image.FromFile(codePath);

                        }
                        if (checkBar.Checked)
                        {
                            var encod = BarcodeEncoding.PDF417;
                            //"Aztec", "Code128", "Code39", "Code93", "DataMatrix", "PDF417"
                            switch (Array.IndexOf(encodind, cBEncoding.Text))
                            {
                                case 0:
                                    encod = BarcodeEncoding.Aztec;
                                    break;
                                case 1:
                                    encod = BarcodeEncoding.Code128;
                                    break;
                                case 2:
                                    encod = BarcodeEncoding.Code39;
                                    break;
                                case 3:
                                    encod = BarcodeEncoding.Code93;
                                    break;
                                case 4:
                                    encod = BarcodeEncoding.DataMatrix;
                                    break;
                            }
                            Code = BarcodeWriter.CreateBarcode(text, encod);
                            Color(sender);
                            Code.SaveAsPng(codePath);
                            pictureBox1.Image = Image.FromFile(codePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании кода: " + ex.Message);
                }
            }
        }

        private bool Check(object sender)
        {
            if (String.IsNullOrEmpty(tBText.Text) && !checkQR.Checked && !checkBar.Checked)
            {
                errorProvider1.SetError(tBText, "Не указан текст");
                errorProvider2.SetError(checkBar, "Не выбран формат кода");
                return true;
            }
            else if (String.IsNullOrEmpty(tBText.Text))
            {
                errorProvider1.SetError(tBText, "Не указан текст");
                return true;
            }
            else if (!checkQR.Checked && !checkBar.Checked)
            {
                errorProvider2.SetError(checkBar, "Не выбран формат кода");
                return true;
            }
            
            else if (!String.IsNullOrEmpty(tBText.Text) && (checkQR.Checked || checkBar.Checked))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                return false;
            }
            else return false;
        }

        private void bPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                tBPath.Text = selectedFolder;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string destination = tBPath.Text + "/" + tBName.Text + cBExtension.Text;
            //".png", ".pdf", ".jpeg", ".gif", ".html", ".tiff", ".bmp"
            switch (Array.IndexOf(extension, cBExtension.Text))
            {
                case 0:
                    Code.SaveAsPng(destination);
                    break;
                case 1:
                    Code.SaveAsPdf(destination);
                    break;
                case 2:
                    Code.SaveAsJpeg(destination);
                    break;
                case 3:
                    Code.SaveAsImage(destination);
                    break;
                case 4:
                    Code.SaveAsGif(destination);
                    break;
                case 5:
                    Code.SaveAsHtmlFile(destination);
                    break;
                case 6:
                    Code.SaveAsWindowsBitmap(destination);
                    break;
            }
        }

        private void checkQR_CheckedChanged(object sender, EventArgs e)
        {
            Check(sender);
            if (checkQR.Checked)
            {
                checkBar.Checked = false;
                pictureBox1.Visible = true;
                pictureBox1.Image = null;
                gBQR.Visible = true; gBQR.Enabled = true;
                gBBar.Visible = false; gBBar.Enabled = false;
            }
        }

        private void checkBar_CheckedChanged(object sender, EventArgs e)
        {
            Check(sender);
            if (checkBar.Checked)
            {
                checkQR.Checked = false;
                pictureBox1.Visible = true;
                pictureBox1.Image = null;
                gBQR.Visible = false; gBQR.Enabled = false;
                gBBar.Visible = true; gBBar.Enabled = true;
            }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void cBColor_CheckedChanged(object sender, EventArgs e)
        {
            if (cBColor.Checked)
                bColor.Enabled = true;
            else
                bColor.Enabled = false;
        }

        private void Color(object sender)
        {
            if (cBColor.Checked)
                Code.ChangeBarCodeColor(colorDialog1.Color);
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void textBQRVer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBQRVer_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBQRVer.Text))
            {
                if (Convert.ToInt32(textBQRVer.Text) < 1)
                    textBQRVer.Text = "1";
                if (Convert.ToInt32(textBQRVer.Text) > 40)
                    textBQRVer.Text = "40";
                trackBQRVer.Value = Convert.ToInt32(textBQRVer.Text);
            }
        }

        private void trackBQRVer_Scroll(object sender, EventArgs e)
        {
            textBQRVer.Text = trackBQRVer.Value.ToString();
        }

        private void tBSizeQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
