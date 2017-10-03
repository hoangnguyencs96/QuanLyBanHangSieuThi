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
    public partial class CreateEmployees : Form
    {
        public CreateEmployees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
           
            try
            {
                string sql = "Insert into SalesPerson(Name,DateOfBirth,Salary,Description) values (@Name,@DateOfBirth,@Salary,@Description)";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirthBox.Text;
                cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = SalaryBox.Text;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = Description.Text;
                

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
