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

        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
