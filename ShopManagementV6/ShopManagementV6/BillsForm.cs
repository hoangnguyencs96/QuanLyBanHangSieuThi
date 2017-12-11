using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionSQLServer;
using System.Data.SqlClient;

namespace ShopManagementV6
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }

        public BillsForm(string id, string name)
        {
            InitializeComponent();
            IDSaleBox.Text = id;
            NameSaleBox.Text = name;
        }

        private void ViewBillsBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            string sql = "select ID,BillInfo,CustomerName,SalesPersonID,TotalPrice from Bill";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);

            BillGridView.DataSource = dt;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            string theDate = SpecificDay.Value.ToString("MM/dd/yyyy");
            string starttime = theDate + " 00:00:00 AM";
            string endtime = theDate + " 11:59:59 PM";

            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            string sql = "select ID,BillInfo,CustomerName,SalesPersonID,TotalPrice from Bill where SoldDate>='"+starttime+"' and SoldDate<='"+endtime+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);

            BillGridView.DataSource = dt;
        }

        private void CountBut_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)BillGridView.DataSource;
            if (dt == null)
            {
                MessageBox.Show("Please get some bills to the table in order to count what we earned!", "Lack of input");
                return;
            }
            double sum = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                sum += Double.Parse(dt.Rows[i]["TotalPrice"].ToString());
            }
            CountBox.Text = sum.ToString();
        }

        private void BillGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = BillGridView.CurrentCell.RowIndex;
                string BillInfo = BillGridView.Rows[i].Cells[1].Value.ToString();
                string sql = "select ProductID,ProductName,Quantity,BillInfo,TotalPrice from ProductsBill where BillInfo='" + BillInfo + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                ProductBillGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void BillGridView_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = BillGridView.CurrentCell.RowIndex;
                string BillInfo = BillGridView.Rows[i].Cells[1].Value.ToString();
                string sql = "select ProductID,ProductName,Quantity,BillInfo,TotalPrice from ProductsBill where BillInfo='" + BillInfo + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                ProductBillGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }

        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            DataTable dt = new DataTable();

            string searchname = "%" + SearchBox.Text + "%";
            string searchdes = "%" + SearchBox.Text + "%";

            string sql = @"select ProductID,ProductName,Quantity,BillInfo,TotalPrice from ProductsBill where (ProductName like '" + searchname + "')";

            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            ProductBillGridView.DataSource = dt;
            cnn.Close();

        }

        private void ProductBillGridView_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = ProductBillGridView.CurrentCell.RowIndex;
                string BillInfo = ProductBillGridView.Rows[i].Cells[3].Value.ToString();
                string sql = "select ID,BillInfo,CustomerName,SalesPersonID,TotalPrice from Bill where BillInfo='" + BillInfo + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                BillGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to find: " + x.Message);
            }
            -----------------------------------------------------------
if (e.KeyChar == 13)
            {
                SqlConnection cnn = DBUtils.GetDBConnection();
                cnn.Open();

                DataTable dt = new DataTable();

                string searchname = "%" + SearchBox.Text + "%";
                string searchdes = "%" + SearchBox.Text + "%";

                string sql = @"select ProductID,ProductName,Quantity,BillInfo,TotalPrice from ProductsBill where (ProductName like '" + searchname + "')";

                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);
                ProductBillGridView.DataSource = dt;
                cnn.Close();
            }

        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AdvanceBut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
