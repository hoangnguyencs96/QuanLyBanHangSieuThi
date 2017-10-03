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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            string sql = "select UserName,Name,SalesPersonID from Account where IsAdmin = 1";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            AdminGridView.DataSource = dt;

            sql = "select UserName,Name,SalesPersonID,Descriptions,DateOfBirth from Account";
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(sql, cnn);
            sda2.Fill(dt2);
            AccountGridView.DataSource = dt2;
        }

        private void InsertBut_Click(object sender, EventArgs e)
        {
            var mf = new CreateAccForm();
            mf.Closed += (s, args) => this.LoadData();
            mf.Show();

        }

        private void AccountGridView_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = AccountGridView.CurrentCell.RowIndex;
                string SaleID = AccountGridView.Rows[i].Cells[2].Value.ToString();
                string sql = "select ID,Name,DateOfBirth from SalesPerson where ID=" + SaleID;
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                EmployeesGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void AdminGridView_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = AdminGridView.CurrentCell.RowIndex;
                string SaleID = AdminGridView.Rows[i].Cells[2].Value.ToString();
                string sql = "select ID,Name,DateOfBirth from SalesPerson where ID=" + SaleID;
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                EmployeesGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this account from database?", "Are your sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = AccountGridView.CurrentCell.RowIndex;
                string UserName = AccountGridView.Rows[i].Cells[0].Value.ToString();
                string sql = "delete Account where UserName='" + UserName+"'";
                cmd.CommandText = sql;
                int rowCount = cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select UserName,Name,SalesPersonID,Descriptions,DateOfBirth from Account", cnn);
                sda.Fill(dt);

                AccountGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int i = AccountGridView.CurrentCell.RowIndex;

            string username = AccountGridView.Rows[i].Cells[0].Value.ToString();
            string name = AccountGridView.Rows[i].Cells[1].Value.ToString();
            string salepersonid = AccountGridView.Rows[i].Cells[2].Value.ToString();
            string descriptions = AccountGridView.Rows[i].Cells[3].Value.ToString();
            string dateofbirth = AccountGridView.Rows[i].Cells[4].Value.ToString();
            
            var mf = new EditAccForm(username, name, salepersonid, descriptions, dateofbirth);
            mf.Closed += (s, args) => this.LoadData();
            mf.Show();
            
        }

        private void LoadData()
        {
            string sql = "select UserName,Name,SalesPersonID from Account where IsAdmin = 1";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            AdminGridView.DataSource = dt;

            sql = "select UserName,Name,SalesPersonID,Descriptions,DateOfBirth from Account";
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(sql, cnn);
            sda2.Fill(dt2);
            AccountGridView.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select UserName,Name,SalesPersonID from Account where IsAdmin = 1";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            AdminGridView.DataSource = dt;

            sql = "select UserName,Name,SalesPersonID,Descriptions,DateOfBirth from Account";
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(sql, cnn);
            sda2.Fill(dt2);
            AccountGridView.DataSource = dt2;
        }

        
    }
}
