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
using BitMiracle.LibTiff.Classic;
using SixLabors.ImageSharp.Formats.Gif;

namespace BarcodeTest
{
    public partial class Form3 : Form
    {
        private string[] extension = { ".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".bmp" };
        private BarcodeResults CodeResults;
        public Form3()
        {
            InitializeComponent();
        }

        private void bSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tBFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void bReadFile_Click(object sender, EventArgs e)
        {
            //".png", ".pdf", ".jpeg", ".jpg", ".gif", ".html", ".tiff", ".bmp"
            rTB.Text = null;
            switch (Array.IndexOf(extension, Path.GetExtension(tBFilePath.Text)))
            {
                case 0:
                    CodeResults = BarcodeReader.Read(tBFilePath.Text);
                    reWrite(sender, CodeResults);
                    break;
                case 1:
                    CodeResults = BarcodeReader.ReadPdf(tBFilePath.Text);
                    reWrite(sender, CodeResults);
                    break;
                case 2-6:
                    CodeResults = BarcodeReader.Read(tBFilePath.Text);
                    reWrite(sender, CodeResults);
                    break;
                default:
                    try
                    {
                        CodeResults = BarcodeReader.Read(tBFilePath.Text);
                        reWrite(sender, CodeResults);
                    }
                    catch //Exception ex
                    {
                        MessageBox.Show("Вы выбрали неверный формат файла");
                    }
                    break;
            }
            
        }

        private void reWrite (object sender, BarcodeResults Results)
        {
            foreach (var item in Results)
            {
                rTB.Text += item.ToString() + "\n";
                Console.WriteLine(item.ToString());
            }
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
