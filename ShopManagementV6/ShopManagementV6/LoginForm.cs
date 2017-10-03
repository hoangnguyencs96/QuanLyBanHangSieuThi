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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PasswordBox.Text;
            SqlConnection cnn = DBUtils.GetDBConnection();
            cnn.Open();

            DataTable dt = new DataTable();
            string sql= @"select * from Account where UserName='"+username+"' and Password='"+password+"'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            int rowCount = dt.Rows.Count;
            if (rowCount > 0)
            {
                string sql2 = @"select * from Account where UserName='"+username+"' and Password='"+password+"' and IsAdmin=1";
                DataTable dt2 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn);
                sda2.Fill(dt2);
                int rowCount2 = dt2.Rows.Count;
                if (rowCount2 > 0)
                {
                    this.Hide();
                    var mf = new MainForm(username);
                    mf.Closed += (s, args) => this.Close();
                    mf.Show();
                }
                else
                {
                    this.Hide();
                    var mf = new CartForm(username);
                    mf.Closed += (s, args) => this.Close();
                    mf.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong username and password");
            }
            cnn.Close();
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string username = UserBox.Text;
                string password = PasswordBox.Text;
                SqlConnection cnn = DBUtils.GetDBConnection();
                cnn.Open();

                DataTable dt = new DataTable();
                string sql = @"select * from Account where UserName='" + username + "' and Password='" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);
                int rowCount = dt.Rows.Count;
                if (rowCount > 0)
                {
                    string sql2 = @"select * from Account where UserName='" + username + "' and Password='" + password + "' and IsAdmin=1";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn);
                    sda2.Fill(dt2);
                    int rowCount2 = dt2.Rows.Count;
                    if (rowCount2 > 0)
                    {
                        this.Hide();
                        var mf = new MainForm(username);
                        mf.Closed += (s, args) => this.Close();
                        mf.Show();
                    }
                    else
                    {
                        this.Hide();
                        var mf = new CartForm(username);
                        mf.Closed += (s, args) => this.Close();
                        mf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username and password");
                }
                cnn.Close();
            }
        }

        private void UserBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string username = UserBox.Text;
                string password = PasswordBox.Text;
                SqlConnection cnn = DBUtils.GetDBConnection();
                cnn.Open();

                DataTable dt = new DataTable();
                string sql = @"select * from Account where UserName='" + username + "' and Password='" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                sda.Fill(dt);
                int rowCount = dt.Rows.Count;
                if (rowCount > 0)
                {
                    string sql2 = @"select * from Account where UserName='" + username + "' and Password='" + password + "' and IsAdmin=1";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn);
                    sda2.Fill(dt2);
                    int rowCount2 = dt2.Rows.Count;
                    if (rowCount2 > 0)
                    {
                        this.Hide();
                        var mf = new MainForm(username);
                        mf.Closed += (s, args) => this.Close();
                        mf.Show();
                    }
                    else
                    {
                        this.Hide();
                        var mf = new CartForm(username);
                        mf.Closed += (s, args) => this.Close();
                        mf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username and password");
                }
                cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mf = new CreateAccForm();
            mf.Closed += (s, args) => this.Show();
            mf.Show();
        }
    }
}
