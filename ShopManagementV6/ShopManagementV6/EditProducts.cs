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
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        public EditProducts(string IDSpecify, string productname, string productdes, string quantity, string price)
        {
            InitializeComponent();
            IDBox.Text = IDSpecify;
            NameBox.Text = productname;
            DescBox.Text = productdes;
            QuantityBox.Text = quantity;
            PriceBox.Text = price;
            NameBox.Select();
        }

        private void SubmitBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql_cmd = "Update Product set ProductName=@Name,ProductDescription=@Des,Quantity=@Quantity,Price=@Price where ID = @ID";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql_cmd;

                cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = Int32.Parse(IDBox.Text);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Des", SqlDbType.NVarChar).Value = DescBox.Text;
                int quantity = Int32.Parse(QuantityBox.Text);
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                double price = Double.Parse(PriceBox.Text);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!", "Information");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
