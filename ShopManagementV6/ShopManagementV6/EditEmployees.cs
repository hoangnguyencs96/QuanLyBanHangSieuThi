using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectionSQLServer;

namespace ShopManagementV6
{
    public partial class EditEmployees : Form
    {
        public EditEmployees(string ID,string name,string dateofbirth,string salary,string description)
        {
            InitializeComponent();
            IDBox.Text = ID;
            NameBox.Text = name;
            DateOfBirthBox.Text = dateofbirth;
            SalaryBox.Text = salary;
            DescriptionBox.Text = description;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Editbut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql_cmd = "Update SalesPerson set Name=@Name,Description=@Descriptions,DateOfBirth=@DateOfBirth,Salary=@Salary where ID=@ID";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql_cmd;

                cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = Int32.Parse(IDBox.Text);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Descriptions", SqlDbType.NVarChar).Value = DescriptionBox.Text;
                cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirthBox.Text ;
                cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = Double.Parse(SalaryBox.Text);

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!", "Information");
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
