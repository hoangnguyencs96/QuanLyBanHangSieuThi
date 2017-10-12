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
        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this product's informations from database?", "Are your sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int i = ProductsGridView.CurrentCell.RowIndex;
                string value = ProductsGridView.Rows[i].Cells[0].Value.ToString();
                cmd.CommandText = "Delete from Product where ID='" + value + "'";
                int count = cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }
        private void EditBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();

            int i = ProductsGridView.CurrentCell.RowIndex;

            string IDSpecify = ProductsGridView.Rows[i].Cells[0].Value.ToString();
            string productname = ProductsGridView.Rows[i].Cells[1].Value.ToString();
            string productdes = ProductsGridView.Rows[i].Cells[2].Value.ToString();
            string quantity = ProductsGridView.Rows[i].Cells[3].Value.ToString();
            string price = ProductsGridView.Rows[i].Cells[4].Value.ToString();

            EditProducts ep = new EditProducts(IDSpecify,productname,productdes,quantity,price);
            ep.ShowDialog();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Product", cnn);
            sda.Fill(dt);
            ProductsGridView.DataSource = dt;
            cnn.Close();
        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            DataTable dt = new DataTable();

            string searchname = "%" + SearchBox.Text + "%";
            string searchdes = "%" + SearchBox.Text + "%";
            string order = (string)SortComboBox.SelectedItem;

            string sql;
            if (order == "" || order == null || order == "None(Default)")
            {
                if (OrderRadioButton.Checked == false)
                {
                    sql = @"select * from Product where (ProductName like '" + searchname + "') or (ProductDescription like '" + searchdes + "')";
                }
                else
                {
                    sql = @"select * from Product where (ProductName like '" + searchname + "') or (ProductDescription like '" + searchdes + "')";
                }
            }
            else
            {
                if (OrderRadioButton.Checked == false)
                {
                    sql = @"select * from Product where (ProductName like '" + searchname + "') or (ProductDescription like '" + searchdes + "')" + " order by " + order + " desc;";
                }
                else
                {
                    sql = @"select * from Product where (ProductName like '" + searchname + "') or (ProductDescription like '" + searchdes + "')" + " order by " + order + " asc;";
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            ProductsGridView.DataSource = dt;
            cnn.Close();
        }

    }
}
