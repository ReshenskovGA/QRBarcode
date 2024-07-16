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

namespace QRBarcode
{
    public partial class FormCreateCode : Form
    {
        private enum Strcorlev
        {
            Высочайший,
            Высокий,
            Средний,
            Низкий
        }
        private enum Encodind
        {
            Aztec,
            Code128,
            Code39,
            Code93,
            DataMatrix,
            PDF417
        }
       
        private GeneratedBarcode Code;
        private static readonly string Folderpath = "SaveCodes/";
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
            try
            {
                CreateCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании кода: " + ex.Message);
            }
        }

        private void CreateCode()
        {
            if (!Check())
            {
                Numcode++;
                var basesize = "500";
                var basever = "1";
                var Codepath = Folderpath + Numcode + ".png";
                var Text = TBText.Text;
                if (CheckQR.Checked)
                {
                    if (String.IsNullOrEmpty(TBSizeQR.Text))
                        TBSizeQR.Text = basesize;
                    if (String.IsNullOrEmpty(TextBQRVer.Text))
                        TextBQRVer.Text = basever;
                    CreateQR(Text, Codepath);
                }
                if (CheckBar.Checked)
                {
                    CreateBar(Text, Codepath);
                }
            }
        }

        private void CreateQR(string text, string path)
        {
            QRCodeWriter.QrErrorCorrectionLevel correction;
            //"Высочайший", "Высокий", "Средний", "Низкий"
            switch (Enum.Parse(typeof(Strcorlev), CBErrorCor.Text, true))
            {
                case Strcorlev.Высочайший:
                    correction = QRCodeWriter.QrErrorCorrectionLevel.Highest;
                    break;
                case Strcorlev.Средний:
                    correction = QRCodeWriter.QrErrorCorrectionLevel.Medium;
                    break;
                case Strcorlev.Низкий:
                    correction = QRCodeWriter.QrErrorCorrectionLevel.Low;
                    break;
                default:
                    correction = QRCodeWriter.QrErrorCorrectionLevel.High;
                    break;
            }
            var size = Convert.ToInt32(TBSizeQR.Text);
            var verQR = Convert.ToInt32(TextBQRVer.Text);
            Code = QRCodeWriter.CreateQrCode(text, size, correction, verQR);
            Color();
            Code.SaveAsPng(path);
            SetImage(path);
        }
        private void CreateBar(string text, string path)
        {
            BarcodeEncoding encod;
            //"Aztec", "Code128", "Code39", "Code93", "DataMatrix", "PDF417"
            switch (Enum.Parse(typeof(Encodind), CBEncoding.Text, true))
            {
                case Encodind.Aztec:
                    encod = BarcodeEncoding.Aztec;
                    break;
                case Encodind.Code128:
                    encod = BarcodeEncoding.Code128;
                    break;
                case Encodind.Code39:
                    encod = BarcodeEncoding.Code39;
                    break;
                case Encodind.Code93:
                    encod = BarcodeEncoding.Code93;
                    break;
                case Encodind.DataMatrix:
                    encod = BarcodeEncoding.DataMatrix;
                    break;
                default:
                    encod = BarcodeEncoding.PDF417;
                    break;
            }
            Code = BarcodeWriter.CreateBarcode(text, encod);
            Color();
            Code.SaveAsPng(path);
            SetImage(path);
        }

        private void SetImage(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
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
            else
            {
                if (!String.IsNullOrEmpty(TBText.Text))
                {
                    errorProvider1.Clear();
                }
                if (CheckQR.Checked || CheckBar.Checked)
                {
                    errorProvider2.Clear();
                }
                return false;
            }
        }

        private void BPath_Click(object sender, EventArgs e)
        {
            try
            {
                ChoicePath();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборе каталога: " + ex.Message);
            }
        }

        private void ChoicePath()
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
            try
            {
                SaveFile();
                MessageBox.Show("Файл был успешно сохранён");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void SaveFile()
        {
            var dot = ".";
            var fileext = TBName.Text + dot + CBExtension.Text;
            string[] path = {TBPath.Text, fileext};
            var destination = Path.Combine(path);
            Console.WriteLine(destination);
            //"png", "pdf", "jpeg", "jpg", ".gif", "html", "bmp"
            FileExtensions.FileExtension selectedExtension = (FileExtensions.FileExtension)Enum.Parse(typeof(FileExtensions.FileExtension), CBExtension.Text, true);
            switch (selectedExtension)
            {
                case FileExtensions.FileExtension.png:
                    Code.SaveAsPng(destination);
                    break;
                case FileExtensions.FileExtension.pdf:
                    Code.SaveAsPdf(destination);
                    break;
                case FileExtensions.FileExtension.jpeg:
                    Code.SaveAsJpeg(destination);
                    break;
                case FileExtensions.FileExtension.jpg:
                    Code.SaveAsImage(destination);
                    break;
                case FileExtensions.FileExtension.gif:
                    Code.SaveAsGif(destination);
                    break;
                case FileExtensions.FileExtension.html:
                    Code.SaveAsHtmlFile(destination);
                    break;
                case FileExtensions.FileExtension.bmp:
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
            var minver = "1";
            var maxver = "40";
            if (!String.IsNullOrEmpty(TextBQRVer.Text))
            {
                if (Convert.ToInt32(TextBQRVer.Text) < Convert.ToInt32(minver))
                    TextBQRVer.Text = minver;
                if (Convert.ToInt32(TextBQRVer.Text) > Convert.ToInt32(maxver))
                    TextBQRVer.Text = maxver;
                TrackBQRVer.Value = Convert.ToInt32(TextBQRVer.Text);
            }
        }

        private void TrackBQRVer_Scroll(object sender, EventArgs e)
        {
            TextBQRVer.Text = TrackBQRVer.Value.ToString();
        }

        private void TBSizeQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBText_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}