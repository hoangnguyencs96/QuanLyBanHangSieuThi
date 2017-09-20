namespace ShopManagementV6
{
    partial class CreateAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccForm));
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminBox = new System.Windows.Forms.CheckBox();
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(109, 50);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(125, 20);
            this.UserBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(109, 78);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(125, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // ConfirmPassBox
            // 
            this.ConfirmPassBox.Location = new System.Drawing.Point(109, 109);
            this.ConfirmPassBox.Name = "ConfirmPassBox";
            this.ConfirmPassBox.PasswordChar = '*';
            this.ConfirmPassBox.Size = new System.Drawing.Size(125, 20);
            this.ConfirmPassBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(44, 329);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(75, 23);
            this.CreateBut.TabIndex = 6;
            this.CreateBut.Text = "Create";
            this.CreateBut.UseVisualStyleBackColor = true;
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(125, 329);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 7;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Create An Account";
            // 
            // AdminBox
            // 
            this.AdminBox.AutoSize = true;
            this.AdminBox.Location = new System.Drawing.Point(92, 296);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(55, 17);
            this.AdminBox.TabIndex = 9;
            this.AdminBox.Text = "Admin";
            this.AdminBox.UseVisualStyleBackColor = true;
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Location = new System.Drawing.Point(12, 135);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.Size = new System.Drawing.Size(222, 144);
            this.EmployeesGridView.TabIndex = 10;
            // 
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 366);
            this.Controls.Add(this.EmployeesGridView);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPassBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccForm";
            this.Text = "Create an Account";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox ConfirmPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AdminBox;
        private System.Windows.Forms.DataGridView EmployeesGridView;
    }
}