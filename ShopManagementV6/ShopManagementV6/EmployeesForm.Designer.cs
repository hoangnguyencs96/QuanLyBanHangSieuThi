namespace ShopManagementV6
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            this.BillsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertBut = new System.Windows.Forms.Button();
            this.EditBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.ShowBut = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Location = new System.Drawing.Point(12, 24);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.Size = new System.Drawing.Size(674, 155);
            this.EmployeesGridView.TabIndex = 1;
            this.EmployeesGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmployeesGridView_MouseClick);
            // 
            // BillsGridView
            // 
            this.BillsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsGridView.Location = new System.Drawing.Point(325, 207);
            this.BillsGridView.Name = "BillsGridView";
            this.BillsGridView.Size = new System.Drawing.Size(361, 144);
            this.BillsGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bills sold by Employee";
            // 
            // InsertBut
            // 
            this.InsertBut.Location = new System.Drawing.Point(31, 281);
            this.InsertBut.Name = "InsertBut";
            this.InsertBut.Size = new System.Drawing.Size(75, 23);
            this.InsertBut.TabIndex = 5;
            this.InsertBut.Text = "Insert";
            this.InsertBut.UseVisualStyleBackColor = true;
            this.InsertBut.Click += new System.EventHandler(this.InsertBut_Click);
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(126, 281);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(75, 23);
            this.EditBut.TabIndex = 6;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(218, 281);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 7;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // ShowBut
            // 
            this.ShowBut.Location = new System.Drawing.Point(126, 206);
            this.ShowBut.Name = "ShowBut";
            this.ShowBut.Size = new System.Drawing.Size(75, 23);
            this.ShowBut.TabIndex = 8;
            this.ShowBut.Text = "Show All";
            this.ShowBut.UseVisualStyleBackColor = true;
            this.ShowBut.Click += new System.EventHandler(this.ShowBut_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(218, 239);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 20);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(112, 239);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBox.TabIndex = 11;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 363);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ShowBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.InsertBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillsGridView);
            this.Controls.Add(this.EmployeesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesForm";
            this.Text = "Employees Management";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesGridView;
        private System.Windows.Forms.DataGridView BillsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertBut;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button ShowBut;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
    }
}