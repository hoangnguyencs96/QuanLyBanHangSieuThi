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
    public partial class EditAccForm : Form
    {
        public EditAccForm(string username, string name, string salepersonid, string descriptions, string dateofbirth)
        {
            InitializeComponent();
            UserBox.Text = username;
            NameBox.Text = name;
            IDBox.Text = salepersonid;
            DesBox.Text = descriptions;
            DateOfBirthBox.Text = dateofbirth;
        }

        private void EditAccForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {

        }
    }
}
