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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }
        public CartForm(string id, string name)
        {
            InitializeComponent();
            IDSaleBox.Text = id;
            NameSaleBox.Text = name;
        }

        public CartForm(string username)
        {
            InitializeComponent();
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            string sql = "select * from Account where UserName='" + username + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);

            string a = dt.Rows[0]["SalesPersonID"].ToString();

            string sql2 = "select * from SalesPerson where ID=" + a;
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn);
            sda2.Fill(dt2);

            IDSaleBox.Text = a;
            NameSaleBox.Text = dt2.Rows[0]["Name"].ToString();
            cnn.Close();
        }

        private void ViewBut_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Product Name", typeof(string));
            dt.Columns.Add("Product Description", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Total Price", typeof(double));

            DataRow row = dt.NewRow();

            row["ID"] = 1;
            row["Product Name"] = "DELL INSPIRON";
            row["Product Description"] = "DELL";
            row["Quantity"] = 2;
            row["Price"] = 10000000;
            row["Total Price"] = 20000000;
            dt.Rows.Add(row);


            CartGridView.DataSource = dt;
        }

        private void TestBut2_Click(object sender, EventArgs e)
        {
            DataTable dtt = (DataTable)CartGridView.DataSource;
            DataRow row = dtt.NewRow();

            row["ID"] = 2;
            row["Product Name"] = "DELL INSPIRON 123123";
            row["Product Description"] = "DELL 2131231";
            row["Quantity"] = 3;
            row["Price"] = 10000000;
            row["Total Price"] = 20000000;
            dtt.Rows.Add(row);

            CartGridView.DataSource = dtt;
        }

        private void AddCartBut_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            
        }

        private void CountBut_Click(object sender, EventArgs e)
        {
            
        }

        private void CompleteBut_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
