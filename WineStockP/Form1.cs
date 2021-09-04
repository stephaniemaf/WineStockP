using System;
using System.Windows.Forms;

namespace WineShop
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
        }

        private void btnEnterShop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStock f2 = new frmStock();
            f2.Show();

        }

        private void btnEnterclub_Click(object sender, EventArgs e)
        {

        }

        private void frmEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
