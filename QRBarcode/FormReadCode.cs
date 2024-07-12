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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TBFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void BReadFile_Click(object sender, EventArgs e)
        {
            //".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".tiff", ".bmp"
            rTB.Text = null;
            switch (Array.IndexOf(extension, Path.GetExtension(TBFilePath.Text)))
            {
                case 0:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(sender, CodeResults);
                    break;
                case 1:
                    CodeResults = BarcodeReader.ReadPdf(TBFilePath.Text);
                    ReWrite(sender, CodeResults);
                    break;
                case 2 - 6:
                    CodeResults = BarcodeReader.Read(TBFilePath.Text);
                    ReWrite(sender, CodeResults);
                    break;
                default:
                    try
                    {
                        CodeResults = BarcodeReader.Read(TBFilePath.Text);
                        ReWrite(sender, CodeResults);
                    }
                    catch //Exception ex
                    {
                        MessageBox.Show("Вы выбрали неверный формат файла");
                    }
                    break;
            }

        }

        private void ReWrite(object sender, BarcodeResults Results)
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
