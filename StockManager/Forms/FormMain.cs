using StockManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFII_Click(object sender, EventArgs e)
        {
            using (FormFII formFII = new FormFII())
            {
                this.Hide();

                formFII.Owner = this;
                formFII.StartPosition = FormStartPosition.CenterParent;
                formFII.ShowDialog();

                this.Show();
            }
        }
    }
}
