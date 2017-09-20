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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
