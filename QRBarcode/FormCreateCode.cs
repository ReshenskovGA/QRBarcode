using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace QRBarcode
{
    public partial class FormCreateCode : Form
    {
        private static readonly string[] extension = { ".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".bmp" };
        //Extension extension = new Extension();
        private static readonly string[] Strcorlev = { "Высочайший", "Высокий", "Средний", "Низкий" };
        private static readonly string[] Encodind = { "Aztec", "Code128", "Code39", "Code93", "DataMatrix", "PDF417" };
        private GeneratedBarcode Code;
        private string Codepath;
        private static readonly string Folderpath = @"SaveCodes/";
        private int Numcode = 0;

        public FormCreateCode()
        {
            InitializeComponent();
            if (Directory.Exists(Folderpath))
            {
                Directory.Delete(Folderpath, true);
                Directory.CreateDirectory(Folderpath);
            }
            else
            {
                Directory.CreateDirectory(Folderpath);
            }
        }

        private void FormCreateCode_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.SolidColorOnly = true;
        }

        private void BGenerate_Click(object sender, EventArgs e)
        {

            if (!Check())
            {
                try
                {
                    Numcode++;
                    Codepath = Folderpath + Numcode + ".png";
                    var text = TBText.Text;
                    if (CheckQR.Checked)
                    {
                        CreateQR(text);
                    }
                    if (CheckBar.Checked)
                    {
                        CreateBar(text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании кода: " + ex.Message);
                }
            }
        }
        private void CreateQR(string text)
        {
            QRCodeWriter.QrErrorCorrectionLevel correction;
            //"Высочайший", "Высокий", "Средний", "Низкий"
            switch (Array.IndexOf(Strcorlev, cBErrorCor.Text))
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
            Color();
            Code.SaveAsPng(Codepath);
            SetImage();
        }
        private void CreateBar(string text)
        {
            var encod = BarcodeEncoding.PDF417;
            //"Aztec", "Code128", "Code39", "Code93", "DataMatrix", "PDF417"
            switch (Array.IndexOf(Encodind, CBEncoding.Text))
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
            Color();
            Code.SaveAsPng(Codepath);
            SetImage();
        }
        private void SetImage()
        {
            pictureBox1.Image = System.Drawing.Image.FromFile(Codepath);
        }
        private bool Check()
        {
            if (String.IsNullOrEmpty(TBText.Text) || (!CheckQR.Checked && !CheckBar.Checked))
            {
                if (String.IsNullOrEmpty(TBText.Text))
                {
                    errorProvider1.SetError(TBText, "Не указан текст");
                }
                if (!CheckQR.Checked && !CheckBar.Checked)
                {
                    errorProvider2.SetError(CheckBar, "Не выбран формат кода");
                }
                return true;
            }
            else if (!String.IsNullOrEmpty(TBText.Text) && (CheckQR.Checked || CheckBar.Checked))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                return false;
            }
            else return false;
        }

        private void BPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                TBPath.Text = selectedFolder;
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            string destination = TBPath.Text + "/" + TBName.Text + CBExtension.Text;
            //".png", ".pdf", ".jpeg", ".gif", ".html", ".tiff", ".bmp"
            
            switch (Array.IndexOf(extension, CBExtension.Text))
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

        private void CheckQR_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (CheckQR.Checked)
            {
                CheckBar.Checked = false;
                pictureBox1.Visible = true;
                pictureBox1.Image = null;
                gBQR.Visible = true;
                gBQR.Enabled = true;
                gBBar.Visible = false;
                gBBar.Enabled = false;
            }
        }

        private void CheckBar_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (CheckBar.Checked)
            {
                CheckQR.Checked = false;
                pictureBox1.Visible = true;
                pictureBox1.Image = null;
                gBQR.Visible = false;
                gBQR.Enabled = false;
                gBBar.Visible = true;
                gBBar.Enabled = true;
            }
        }

        private void BColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void CBColor_CheckedChanged(object sender, EventArgs e)
        {
            BColor.Enabled = CBColor.Checked;
        }

        private void Color()
        {
            if (CBColor.Checked)
                Code.ChangeBarCodeColor(colorDialog1.Color);
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            FormChoose formChoose = new FormChoose();
            this.Hide();
            formChoose.ShowDialog();
            this.Close();
        }

        private void TextBQRVer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBQRVer_TextChanged(object sender, EventArgs e)
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

        private void TrackBQRVer_Scroll(object sender, EventArgs e)
        {
            textBQRVer.Text = trackBQRVer.Value.ToString();
        }

        private void TBSizeQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}