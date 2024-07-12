using System;
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
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }
        private void BCreate_Click(object sender, EventArgs e)
        {
            FormCreateCode formCreateCode = new FormCreateCode();
            this.Hide();
            formCreateCode.ShowDialog();
            this.Close();
        }

        private void BRead_Click(object sender, EventArgs e)
        {
            FormReadCode formReadCode = new FormReadCode();
            this.Hide();
            formReadCode.ShowDialog();
            this.Close();
        }
    }
}
