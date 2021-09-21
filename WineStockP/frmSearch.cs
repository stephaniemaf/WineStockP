
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineShop;


namespace WineStockP
{
    public partial class frmSearch : Form
    {

       
        DataSet wineDataSet = new DataSet();
        SqlDataAdapter wineDataAdapter;
        BindingSource wineBindingSource;
        SqlCommandBuilder dbSQLCommands;

        string DBConnectionString = @"Data Source=LAPTOP-BGVAOMTF\SQLEXPRESS;Initial Catalog=WineShop;Integrated Security=True";

        //SqlCommandBuilder dbSQLCommands;

        public frmSearch()
        {
            InitializeComponent();
            this.Text = "Search Stock. Date: " + DateTime.Today.ToLongDateString();

            //populate operator checkbox 
            cboOp.Items.Add("=");
            cboOp.Items.Add(">");
            cboOp.Items.Add("<");
            cboOp.Items.Add(">=");
            cboOp.Items.Add("<=");

            //populate field checkbox
            cboField.Items.Add("WineName");
            cboField.Items.Add("Region");
            cboField.Items.Add("Country");
            cboField.Items.Add("Color");
            cboField.Items.Add("Vintage");
            cboField.Items.Add("Price");
            cboField.Items.Add("Available");

            refreshdata();
        }
        //load database into dataGridView
        private void refreshdata()
        {
            SqlConnection con = new SqlConnection(DBConnectionString);
            SqlCommand cmd = new SqlCommand("Select*from stock", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dgvSearch.DataSource = dt;
            sda.Fill(dt);


            

        }


        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboWineName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            
        }

        // runs the search 
        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dgvSearch.Columns[8].HeaderText.ToString() + " LIKE '%" + cboField.Text + " LIKE '%" + cboOp.Text + " LIKE '%" + txtValue.Text);
            wineBindingSource = new BindingSource();
            wineBindingSource.DataSource = dgvSearch.DataSource;
            wineBindingSource.Filter = cboField.Text.ToString() + cboOp.Text.ToString() /*+ cboField.Text + "%' LIKE '%" + cboOp.Text + "%' LIKE '%"*/ + "'" + txtValue.Text + "'";
            dgvSearch.DataSource = wineBindingSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close frmSearch and open frmStock

            frmStock f2 = new frmStock();
            f2.Show();
            this.Close();
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        // clear cbo and text box fields
        private void btnClear_Click(object sender, EventArgs e)
        {

            cboField.SelectedIndex = -1;
            cboOp.SelectedIndex = -1;
            txtValue.Clear();






        }
        //Reload dataGridView after a search
        private void btnReload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnectionString);
            string query = "Select * From dbo.stock";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearch.DataSource = dt;


        }
    }
}
