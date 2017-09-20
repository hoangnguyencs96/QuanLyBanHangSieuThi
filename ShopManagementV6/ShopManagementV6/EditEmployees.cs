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
    public partial class EditEmployees : Form
    {
        public EditEmployees(string ID,string name,string dateofbirth,string salary,string description)
        {
            InitializeComponent();
            IDBox.Text = ID;
            NameBox.Text = name;
            DateOfBirthBox.Text = dateofbirth;
            SalaryBox.Text = salary;
            DescriptionBox.Text = description;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Editbut_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
