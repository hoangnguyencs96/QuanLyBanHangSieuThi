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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            UserBox.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql_cmd = "select * from Account where UserName='"+UserBox.Text+"' and Password = '"+CurrentPassBox.Text+"'";


                DataTable sc = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql_cmd, cnn);
                sda.Fill(sc);

                if (sc.Rows.Count <= 0)
                {
                    MessageBox.Show("Current Password is wrong!");
                    return;
                }
                if (ConPassBox.Text != NewPassBox.Text)
                {
                    MessageBox.Show("Password does not match!");
                    return;
                }

                string sql = "Update Account set Password = @Password where UserName=@UserName";
                SqlCommand cmd2 = cnn.CreateCommand();
                cmd2.CommandText = sql;
            
                cmd2.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserBox.Text;
                cmd2.Parameters.Add("@Password", SqlDbType.VarChar).Value = NewPassBox.Text;

                int rowCount1 = cmd2.ExecuteNonQuery();
                MessageBox.Show("Change password successful!", "Information");
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
