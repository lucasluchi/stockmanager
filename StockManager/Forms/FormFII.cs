using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
    public partial class FormFII : Form
    {
        public FormFII()
        {
            InitializeComponent();
        }

        private void FormFII_Load(object sender, EventArgs e)
        {

        }

        private void FormFII_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            using (FormAddOperation formAddOperation = new FormAddOperation())
            {
                this.Hide();

                formAddOperation.Owner = this;
                formAddOperation.StartPosition = FormStartPosition.CenterParent;
                formAddOperation.ShowDialog();

                this.Show();
            }
        }
    }
}
