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

       
    }
}
