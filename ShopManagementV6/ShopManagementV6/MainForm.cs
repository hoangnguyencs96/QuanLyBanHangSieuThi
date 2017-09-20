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
    public partial class MainForm : Form
    {
        public MainForm(string username)
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
        private void listOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new ProductsForm();
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void listOfBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new CartForm();
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void listOfProductsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new ProductsForm();
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void listOfBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new CartForm();
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void IDSaleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listOfProductsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new ProductsForm(IDSaleBox.Text,NameSaleBox.Text);
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void listOfBillsToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pf = new BillsForm(IDSaleBox.Text, NameSaleBox.Text);
            pf.Closed += (s, args) => this.Show();
            pf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
