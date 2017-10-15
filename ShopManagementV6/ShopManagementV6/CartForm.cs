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
            DataTable dt = (DataTable)CartGridView.DataSource;
            if (dt == null)
            {
                dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Product Description", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("Left in Storage", typeof(int));
                dt.Columns.Add("Price", typeof(double));
                dt.Columns.Add("Total Price", typeof(double));

                SqlConnection cnn = DBUtils.GetDBConnection();
                cnn.Open();
                try
                {
                    DataTable dt2 = new DataTable();
                    string sql = "select * from Product where ID=" + IDTextBox.Text;

                    SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                    sda.Fill(dt2);
                    DataRow row = dt.NewRow();
                    row["ID"] = Int32.Parse(IDTextBox.Text);
                    row["Product Name"] = dt2.Rows[0]["ProductName"];
                    row["Product Description"] = dt2.Rows[0]["ProductDescription"];
                    row["Quantity"] = Int32.Parse(QuantityBox.Text);
                    row["Left in Storage"] = dt2.Rows[0]["Quantity"];
                    row["Price"] = dt2.Rows[0]["Price"];
                    int a = (int)row["Quantity"];
                    double b = (double)row["Price"];
                    row["Total Price"] = (double)(a * b);

                    dt.Rows.Add(row);
                    CartGridView.DataSource = dt;
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                SqlConnection cnn = DBUtils.GetDBConnection();
                cnn.Open();
                try
                {
                    DataTable dt2 = new DataTable();
                    string sql = "select * from Product where ID=" + IDTextBox.Text;

                    SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                    sda.Fill(dt2);

                    int pos = -1;
                    for(int i=0; i < dt.Rows.Count; i++)
                    {
                        int c = Int32.Parse(dt.Rows[i]["ID"].ToString());
                        if (Int32.Parse(IDTextBox.Text) == c)
                        {
                            pos = i;
                            break;
                        }
                    }
                    if (pos == -1)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = Int32.Parse(IDTextBox.Text);
                        row["Product Name"] = dt2.Rows[0]["ProductName"];
                        row["Product Description"] = dt2.Rows[0]["ProductDescription"];
                        row["Quantity"] = Int32.Parse(QuantityBox.Text);
                        row["Left in Storage"] = dt2.Rows[0]["Quantity"];
                        row["Price"] = dt2.Rows[0]["Price"];
                        int a = (int)row["Quantity"];
                        double b = (double)row["Price"];
                        row["Total Price"] = (double)(a * b);
                        dt.Rows.Add(row);
                    }
                    else
                    {
                        int a = Int32.Parse(dt.Rows[pos]["Quantity"].ToString());
                        a += Int32.Parse(QuantityBox.Text);
                        dt.Rows[pos]["Quantity"] = a.ToString();
                    }
                    CartGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this choice from cart?", "Are your sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                int i = CartGridView.CurrentCell.RowIndex;
                DataTable dt = (DataTable)CartGridView.DataSource;
                dt.Rows.RemoveAt(i);
                CartGridView.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error rised when trying to delete: " + x.Message);
            }
        }

        private void CountBut_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)CartGridView.DataSource;
            if (dt == null)
            {
                CountBox.Text = "Nothing to check out";
                return;
            }
            else
            {
                int rowCount = dt.Rows.Count;
                double TotalPrice = 0;
                for(int i=0; i< rowCount; i++)
                {
                    TotalPrice += (double)dt.Rows[i]["Total Price"];
                }

                CountBox.Text = TotalPrice.ToString();
            }
        }

        private void CompleteBut_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)CartGridView.DataSource;
            if (dt == null)
            {
                MessageBox.Show("Nothing on cart!","Check out error!");
                return;
            }
            string BillInfo = DateTime.Now.ToString();
            string TotalPrice = CountBox.Text;
            string CustomerName = CustomerNameBox.Text;
            string SalesPersonID = IDSaleBox.Text;

            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "insert into Bill(BillInfo,TotalPrice,CustomerName,SalesPersonID) values('"+BillInfo+"',"+TotalPrice+",'"+CustomerName+"',"+SalesPersonID+")";
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string productlist = "";

                for(int i=0; i < dt.Rows.Count; i++)
                {
                    int left = Int32.Parse(dt.Rows[i]["Left in Storage"].ToString());
                    string id = dt.Rows[i]["ID"].ToString();
                    string productname = dt.Rows[i]["Product Name"].ToString();
                    string quantity = dt.Rows[i]["Quantity"].ToString();
                    int iquantity = Int32.Parse(quantity);
                    left = left - iquantity;
                    string updatedquantity = left.ToString();
                    string totalprice = dt.Rows[i]["Total Price"].ToString();
                    string sql_add = "insert into ProductsBill(ProductID,ProductName,Quantity,BillInfo,TotalPrice) values(" + id + ",'" + productname + "'," + quantity + ",'" + BillInfo + "',"+totalprice+")";
                    SqlCommand cmd_add = cnn.CreateCommand();
                    cmd_add.CommandText = sql_add;
                    cmd_add.ExecuteNonQuery();
                    string sql_upd = "update Product set Quantity=" + updatedquantity + " where ID=" + id;
                    SqlCommand cmd_upd = cnn.CreateCommand();
                    cmd_upd.CommandText = sql_upd;
                    cmd_upd.ExecuteNonQuery();

                    productlist += dt.Rows[i]["Product Name"].ToString() + ": " + dt.Rows[i]["Quantity"] + "\n";
                }

                MessageBox.Show("Bill is completed!\n\n"+
                    "Bill Details:\n\n"+
                    productlist+
                    "\n\n"+
                    "Total Price: "+ TotalPrice +"\n\n","Bill Information"
                    );
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            QuantityBox.Text = "";
            CartGridView.DataSource = null;
        }
    }
}
