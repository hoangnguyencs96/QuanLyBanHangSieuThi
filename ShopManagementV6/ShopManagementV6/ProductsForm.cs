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

       
    }
}
