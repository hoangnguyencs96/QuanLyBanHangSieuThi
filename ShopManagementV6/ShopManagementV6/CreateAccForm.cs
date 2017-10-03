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
    public partial class CreateAccForm : Form
    {
        public CreateAccForm()
        {
            InitializeComponent();
            string sql = "select ID,Name from SalesPerson";
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            EmployeesGridView.DataSource = dt;
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            int i = EmployeesGridView.CurrentCell.RowIndex;

            string IDt = EmployeesGridView.Rows[i].Cells[0].Value.ToString();
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            string sql1 = "select * from Account where UserName='" + UserBox.Text + "'";
            DataTable sc = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql1,cnn);
            sda.Fill(sc);
            if(sc.Rows.Count > 0)
            {
                MessageBox.Show("User name has already existed!");
                return;
            }
            try
            {
                if (PasswordBox.Text != ConfirmPassBox.Text)
                {
                    MessageBox.Show("Password does not match!");
                    return;
                }
                string sql = "Insert into Account(UserName,Password,IsAdmin,SalesPersonID) values (@username,@password,@isadmin,@ID)";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = Int32.Parse(IDt);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = UserBox.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordBox.Text;

                if (AdminBox.Checked == true)
                {
                    cmd.Parameters.Add("@isadmin", SqlDbType.Bit).Value = true;
                }
                else
                {
                    cmd.Parameters.Add("@isadmin", SqlDbType.Bit).Value = false;
                }

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Account has been created!");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
