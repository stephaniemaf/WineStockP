using System;
using System.Windows.Forms;
using WineStockP;

namespace WineShop
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
            this.Text = "Chateau Du Vin. - Date: " + DateTime.Today.ToLongDateString(); //add Name and date to forms top bar
        }

        private void btnEnterShop_Click(object sender, EventArgs e)
        {
            //load frmStock and close Entry form
            this.Close();
            frmStock f2 = new frmStock();
            f2.Show();
         

        }

        private void btnEnterclub_Click(object sender, EventArgs e)
        {
            //load frmSearch and hide Entry form
            frmSearch f3 = new frmSearch();
            f3.Show();
            
            
        }

        private void frmEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close app with exit button
            Application.Exit();
        }
    }
}
