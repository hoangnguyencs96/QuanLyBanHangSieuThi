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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            string sql = "select ID,Name,DateOfBirth,Salary,Description from SalesPerson";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            EmployeesGridView.DataSource = dt;
            
        }

        private void LoadData()
        {
            string sql = "select ID,Name,DateOfBirth,Salary,Description from SalesPerson";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            EmployeesGridView.DataSource = dt;
        }

        private void InsertBut_Click(object sender, EventArgs e)
        {
            var mf = new CreateEmployees();
            mf.Closed += (s, args) => this.LoadData();
            mf.Show();
        }

        private void EmployeesGridView_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {

                int i = EmployeesGridView.CurrentCell.RowIndex;
                string SaleID = EmployeesGridView.Rows[i].Cells[0].Value.ToString();
                string sql = "select ID,SoldDate,TotalPrice from Bill where SalesPersonID=" + SaleID;
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);

                BillsGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string sql = "select ID,Name,DateOfBirth,Salary,Description from SalesPerson where Name like '%" + SearchBox.Text + "%'";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            EmployeesGridView.DataSource = dt;
        }

        private void ShowBut_Click(object sender, EventArgs e)
        {
            string sql = "select ID,Name,DateOfBirth,Salary,Description from SalesPerson";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            EmployeesGridView.DataSource = dt;
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this salesperson from database?", "Are your sure?", MessageBoxButtons.YesNo);
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

                int i = EmployeesGridView.CurrentCell.RowIndex;
                string ID = EmployeesGridView.Rows[i].Cells[0].Value.ToString();
                string sql = "delete SalesPerson where ID=" + ID;
                cmd.CommandText = sql;
                int rowCount = cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select ID,Name,DateOfBirth,Salary,Description from SalesPerson", cnn);
                sda.Fill(dt);

                EmployeesGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            int i = EmployeesGridView.CurrentCell.RowIndex;

            string ID = EmployeesGridView.Rows[i].Cells[0].Value.ToString();
            string name = EmployeesGridView.Rows[i].Cells[1].Value.ToString();
            string dateofbirth = EmployeesGridView.Rows[i].Cells[2].Value.ToString();
            string salary = EmployeesGridView.Rows[i].Cells[3].Value.ToString();
            string description = EmployeesGridView.Rows[i].Cells[4].Value.ToString();

            var mf = new EditEmployees(ID, name, dateofbirth, salary, description);
            mf.Closed += (s, args) => this.LoadData();
            mf.Show();
        }
    }
}
