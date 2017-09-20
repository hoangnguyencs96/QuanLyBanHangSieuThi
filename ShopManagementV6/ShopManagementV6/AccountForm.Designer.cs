namespace ShopManagementV6
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.AdminGridView = new System.Windows.Forms.DataGridView();
            this.InsertBut = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangePWBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountGridView
            // 
            this.AccountGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Location = new System.Drawing.Point(12, 190);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.Size = new System.Drawing.Size(538, 159);
            this.AccountGridView.TabIndex = 0;
            this.AccountGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountGridView_MouseClick);
            // 
            // AdminGridView
            // 
            this.AdminGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminGridView.Location = new System.Drawing.Point(12, 32);
            this.AdminGridView.Name = "AdminGridView";
            this.AdminGridView.Size = new System.Drawing.Size(538, 141);
            this.AdminGridView.TabIndex = 1;
            this.AdminGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminGridView_MouseClick);
            // 
            // InsertBut
            // 
            this.InsertBut.Location = new System.Drawing.Point(631, 126);
            this.InsertBut.Name = "InsertBut";
            this.InsertBut.Size = new System.Drawing.Size(75, 23);
            this.InsertBut.TabIndex = 2;
            this.InsertBut.Text = "Create";
            this.InsertBut.UseVisualStyleBackColor = true;
            this.InsertBut.Click += new System.EventHandler(this.InsertBut_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(721, 126);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(80, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(814, 126);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 4;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accounts";
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Location = new System.Drawing.Point(562, 190);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.Size = new System.Drawing.Size(414, 159);
            this.EmployeesGridView.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employees";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(700, 89);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(111, 20);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search";
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(824, 86);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 23);
            this.SearchBut.TabIndex = 11;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePWBut
            // 
            this.ChangePWBut.Location = new System.Drawing.Point(858, 155);
            this.ChangePWBut.Name = "ChangePWBut";
            this.ChangePWBut.Size = new System.Drawing.Size(118, 23);
            this.ChangePWBut.TabIndex = 13;
            this.ChangePWBut.Text = "Change Password";
            this.ChangePWBut.UseVisualStyleBackColor = true;
            this.ChangePWBut.Click += new System.EventHandler(this.ChangePWBut_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Escalate User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "De-escalate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChangePWBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeesGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.InsertBut);
            this.Controls.Add(this.AdminGridView);
            this.Controls.Add(this.AccountGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.Text = "Accounts Management";
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.DataGridView AdminGridView;
        private System.Windows.Forms.Button InsertBut;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EmployeesGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ChangePWBut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}