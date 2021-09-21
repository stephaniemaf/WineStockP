using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using WineStockP;
    

namespace WineShop
{
    public partial class frmStock : Form
    {

        DataSet wineDataSet = new DataSet();
        SqlDataAdapter wineDataAdapter;
        BindingSource wineBindingSource;
        SqlCommandBuilder dbSQLCommands;

        //connection string to the database
        string DBConnectionString = @"Data Source=LAPTOP-BGVAOMTF\SQLEXPRESS;Initial Catalog=WineShop;Integrated Security=True";


        public frmStock()
        {
            InitializeComponent();
            this.Text = "Stock Details - Date: " + DateTime.Today.ToLongDateString();//set date on forms top bar
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //bind data entered by user to the database
            wineBindingSource.AddNew();
        }

        private void BindControls()
        {
            //fill textboxes on form with information from table dbo.stock
            wineBindingSource = new BindingSource(wineDataSet, "dbo.stock");

            txtWineName.DataBindings.Add("Text", wineBindingSource, "WineName");
            txtRegion.DataBindings.Add("Text", wineBindingSource, "Region");
            txtCountry.DataBindings.Add("Text", wineBindingSource, "Country");
            txtVintage.DataBindings.Add("Text", wineBindingSource, "Vintage");
            cboColor.DataBindings.Add("Text", wineBindingSource, "Color");
            txtItemNum.DataBindings.Add("Text", wineBindingSource, "ItemNumber");
            cbhAvailable.DataBindings.Add("Checked", wineBindingSource, "Available", true);
            cboColor.Items.Add("Red");
            cboColor.Items.Add("White");
            cboColor.Items.Add("Rose");

            Binding priceBinding = 
            txtPrice.DataBindings.Add("Text", wineBindingSource, "Price");
            priceBinding.FormatInfo = new CultureInfo("en-IE");
            priceBinding.FormatString = "c";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        private void txtWineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                wineBindingSource.RemoveCurrent();

                dbSQLCommands = new SqlCommandBuilder(wineDataAdapter);

                wineDataAdapter.Update(wineDataSet, "dbo.stock");
                MessageBox.Show("Database update Achieved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wineBindingSource.CancelEdit();
            wineDataSet.RejectChanges();

        }
        private void PageNumDisplay()
        {
            txtPageNum.Text = String.Format("{0} of {1}", 
            wineBindingSource.Position + 1, wineBindingSource.Count);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                wineBindingSource.EndEdit();

                dbSQLCommands = new SqlCommandBuilder(wineDataAdapter);
              
                wineDataAdapter.Update(wineDataSet, "dbo.stock");
                MessageBox.Show("Database update Achieved");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            frmSearch f3 = new frmSearch();
            f3.Show();
            

        }

        private void txtPageNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            wineBindingSource.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            wineBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            wineBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            wineBindingSource.MoveFirst();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                wineDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.stock", DBConnectionString);
                wineDataAdapter.Fill(wineDataSet, "dbo.stock");
                

                MessageBox.Show(new Form { TopMost = true }, "Connected to DB");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":" + ex.Message);
                Application.Exit();
            }
            //cboColor.Items.Add("Red");
            //cboColor.Items.Add("White");
            //cboColor.Items.Add("Rose");
            BindControls();
            PageNumDisplay();

            wineBindingSource.PositionChanged += rowPositionChanged;
        }
        private void rowPositionChanged(object sender, EventArgs e)
        {
            PageNumDisplay();
        }



        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void chbAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
