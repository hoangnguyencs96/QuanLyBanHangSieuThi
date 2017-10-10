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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        public ProductsForm(string id,string name)
        {
            InitializeComponent();
            IDSaleBox.Text = id;
            NameSaleBox.Text = name;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.quanLySieuThiDataSet.Product);

        }


        public void LoadData()
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Product", cnn);
            sda.Fill(dt);
            ProductsGridView.DataSource = dt;
            cnn.Close();
        }

        private void InsertBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql_cmd = "Insert into Product(ProductName,ProductDescription,Quantity,Price) values(@Name,@Des,@Quantity,@Price)";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql_cmd;


                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Des", SqlDbType.NVarChar).Value = DescBox.Text;
                int quantity = Int32.Parse(QuantityBox.Text);
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                double price = Double.Parse(PriceBox.Text);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

                int rowCount = cmd.ExecuteNonQuery();
                LoadData();
            }catch(Exception ex)
            {
                MessageBox.Show("An error rised when trying to insert: " + ex.Message);
            }
        }

    }
}
