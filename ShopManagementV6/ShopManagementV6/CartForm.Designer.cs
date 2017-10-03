namespace ShopManagementV6
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.CompleteBut = new System.Windows.Forms.Button();
            this.ChangeBox = new System.Windows.Forms.TextBox();
            this.PaidBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCartBut = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDSaleBox = new System.Windows.Forms.TextBox();
            this.NameSaleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartGridView
            // 
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(12, 156);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.Size = new System.Drawing.Size(839, 234);
            this.CartGridView.TabIndex = 0;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(219, 28);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CustomerNameBox);
            this.groupBox1.Controls.Add(this.CompleteBut);
            this.groupBox1.Controls.Add(this.ChangeBox);
            this.groupBox1.Controls.Add(this.PaidBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CountBut);
            this.groupBox1.Controls.Add(this.CountBox);
            this.groupBox1.Location = new System.Drawing.Point(441, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer\'s Name";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Location = new System.Drawing.Point(105, 64);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(108, 20);
            this.CustomerNameBox.TabIndex = 12;
            // 
            // CompleteBut
            // 
            this.CompleteBut.Location = new System.Drawing.Point(325, 18);
            this.CompleteBut.Name = "CompleteBut";
            this.CompleteBut.Size = new System.Drawing.Size(75, 39);
            this.CompleteBut.TabIndex = 11;
            this.CompleteBut.Text = "Complete Bill";
            this.CompleteBut.UseVisualStyleBackColor = true;
            this.CompleteBut.Click += new System.EventHandler(this.CompleteBut_Click);
            // 
            // ChangeBox
            // 
            this.ChangeBox.Location = new System.Drawing.Point(289, 76);
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(111, 20);
            this.ChangeBox.TabIndex = 10;
            // 
            // PaidBox
            // 
            this.PaidBox.Location = new System.Drawing.Point(105, 90);
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.Size = new System.Drawing.Size(108, 20);
            this.PaidBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customers have to pay";
            // 
            // CountBut
            // 
            this.CountBut.Location = new System.Drawing.Point(17, 18);
            this.CountBut.Name = "CountBut";
            this.CountBut.Size = new System.Drawing.Size(75, 39);
            this.CountBut.TabIndex = 5;
            this.CountBut.Text = "Check Out";
            this.CountBut.UseVisualStyleBackColor = true;
            this.CountBut.Click += new System.EventHandler(this.CountBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DeleteBut);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.AddCartBut);
            this.groupBox2.Controls.Add(this.QuantityBox);
            this.groupBox2.Controls.Add(this.IDTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add To Cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select product from cart which you want to delete";
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(283, 88);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 10;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCartBut
            // 
            this.AddCartBut.Location = new System.Drawing.Point(308, 37);
            this.AddCartBut.Name = "AddCartBut";
            this.AddCartBut.Size = new System.Drawing.Size(50, 20);
            this.AddCartBut.TabIndex = 8;
            this.AddCartBut.Text = "Add";
            this.AddCartBut.UseVisualStyleBackColor = true;
            this.AddCartBut.Click += new System.EventHandler(this.AddCartBut_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(211, 37);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(91, 20);
            this.QuantityBox.TabIndex = 7;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(81, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(72, 20);
            this.IDTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // IDSaleBox
            // 
            this.IDSaleBox.Location = new System.Drawing.Point(714, 10);
            this.IDSaleBox.Name = "IDSaleBox";
            this.IDSaleBox.ReadOnly = true;
            this.IDSaleBox.Size = new System.Drawing.Size(20, 20);
            this.IDSaleBox.TabIndex = 5;
            // 
            // NameSaleBox
            // 
            this.NameSaleBox.Location = new System.Drawing.Point(740, 10);
            this.NameSaleBox.Name = "NameSaleBox";
            this.NameSaleBox.ReadOnly = true;
            this.NameSaleBox.Size = new System.Drawing.Size(111, 20);
            this.NameSaleBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sales Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Vincom Super Market";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 412);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameSaleBox);
            this.Controls.Add(this.IDSaleBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CartGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CartForm";
            this.Text = "Shopping Cart";
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCartBut;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CountBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button CompleteBut;
        private System.Windows.Forms.TextBox ChangeBox;
        private System.Windows.Forms.TextBox PaidBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDSaleBox;
        private System.Windows.Forms.TextBox NameSaleBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}