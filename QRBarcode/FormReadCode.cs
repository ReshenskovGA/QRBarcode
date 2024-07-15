using IronBarCode;
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

namespace QRBarcode
{
    public partial class FormReadCode : Form
    {
        public FormReadCode()
        {
            InitializeComponent();
        }
        private string[] extension = { ".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".bmp" };
        private BarcodeResults CodeResults;

        private void BSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                SelectFileDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборе файла: " + ex.Message);
            }
        }

        private void SelectFileDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TBFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void BReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                rTB.Text = null;
                ReadCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }

        private void ReadCode()
        {
            //"png", "pdf", "jpeg", "jpg", ".gif", "html", "bmp"
            FileExtensions.FileExtension selectedExtension = (FileExtensions.FileExtension)Enum.Parse(typeof(FileExtensions.FileExtension), Path.GetExtension(TBFilePath.Text).Substring(1), true);
            switch (selectedExtension)
            {
                case FileExtensions.FileExtension.png:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.pdf:
                    CodeResults = BarcodeReader.ReadPdf(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.jpeg:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.jpg:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.gif:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.html:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                case FileExtensions.FileExtension.bmp:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(CodeResults);
                    break;
                default:
                    try
                    {
                        CodeResults = BarcodeReader.Read(TBFilePath.Text);
                        ReWrite(CodeResults);
                    }
                    catch
                    {
                        MessageBox.Show("Вы выбрали неверный формат файла");
                    }
                    break;
            }
        }
        private void ReWrite(BarcodeResults Results)
        {
            foreach (var item in Results)
            {
                rTB.Text += item.ToString() + "\n";
                Console.WriteLine(item.ToString());
            }
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            FormChoose formChoose = new FormChoose();
            this.Hide();
            formChoose.ShowDialog();
            this.Close();
        }
    }
}
