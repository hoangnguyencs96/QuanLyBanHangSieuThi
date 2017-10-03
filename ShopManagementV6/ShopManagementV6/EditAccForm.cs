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
    public partial class EditAccForm : Form
    {
        public EditAccForm(string username, string name, string salepersonid, string descriptions, string dateofbirth)
        {
            InitializeComponent();
            UserBox.Text = username;
            NameBox.Text = name;
            IDBox.Text = salepersonid;
            DesBox.Text = descriptions;
            DateOfBirthBox.Text = dateofbirth;
        }

        private void EditAccForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql_cmd = "Update Account set Name=@Name,Descriptions=@Descriptions,SalesPersonID=@SalesPersonID,DateOfBirth='"+DateOfBirthBox.Text+"' where UserName = @UserName";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql_cmd;

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Descriptions", SqlDbType.NVarChar).Value = DesBox.Text;
                cmd.Parameters.Add("@SalesPersonID", SqlDbType.BigInt).Value = Int32.Parse(IDBox.Text);
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserBox.Text;

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
