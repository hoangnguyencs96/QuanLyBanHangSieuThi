namespace ShopManagementV6
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySieuThiDataSet = new ShopManagementV6.QuanLySieuThiDataSet();
            this.productTableAdapter = new ShopManagementV6.QuanLySieuThiDataSetTableAdapters.ProductTableAdapter();
            this.ProductsBox = new System.Windows.Forms.GroupBox();
            this.IDSaleBox = new System.Windows.Forms.TextBox();
            this.NameSaleBox = new System.Windows.Forms.TextBox();
            this.OrderRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DefaultBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.EditBut = new System.Windows.Forms.Button();
            this.InsertBut = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).BeginInit();
            this.ProductsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoGenerateColumns = false;
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn});
            this.ProductsGridView.DataSource = this.productBindingSource;
            this.ProductsGridView.Location = new System.Drawing.Point(216, 19);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(696, 384);
            this.ProductsGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.quanLySieuThiDataSet;
            // 
            // quanLySieuThiDataSet
            // 
            this.quanLySieuThiDataSet.DataSetName = "QuanLySieuThiDataSet";
            this.quanLySieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsBox
            // 
            this.ProductsBox.Controls.Add(this.IDSaleBox);
            this.ProductsBox.Controls.Add(this.NameSaleBox);
            this.ProductsBox.Controls.Add(this.OrderRadioButton);
            this.ProductsBox.Controls.Add(this.label5);
            this.ProductsBox.Controls.Add(this.SortComboBox);
            this.ProductsBox.Controls.Add(this.SearchBut);
            this.ProductsBox.Controls.Add(this.SearchBox);
            this.ProductsBox.Controls.Add(this.DefaultBut);
            this.ProductsBox.Controls.Add(this.DeleteBut);
            this.ProductsBox.Controls.Add(this.EditBut);
            this.ProductsBox.Controls.Add(this.ProductsGridView);
            this.ProductsBox.Controls.Add(this.InsertBut);
            this.ProductsBox.Controls.Add(this.PriceBox);
            this.ProductsBox.Controls.Add(this.QuantityBox);
            this.ProductsBox.Controls.Add(this.DescBox);
            this.ProductsBox.Controls.Add(this.NameBox);
            this.ProductsBox.Controls.Add(this.label4);
            this.ProductsBox.Controls.Add(this.label3);
            this.ProductsBox.Controls.Add(this.label2);
            this.ProductsBox.Controls.Add(this.label1);
            this.ProductsBox.Location = new System.Drawing.Point(12, 6);
            this.ProductsBox.Name = "ProductsBox";
            this.ProductsBox.Size = new System.Drawing.Size(918, 415);
            this.ProductsBox.TabIndex = 1;
            this.ProductsBox.TabStop = false;
            this.ProductsBox.Text = "Products";
            // 
            // IDSaleBox
            // 
            this.IDSaleBox.Location = new System.Drawing.Point(50, 19);
            this.IDSaleBox.Name = "IDSaleBox";
            this.IDSaleBox.ReadOnly = true;
            this.IDSaleBox.Size = new System.Drawing.Size(23, 20);
            this.IDSaleBox.TabIndex = 2;
            // 
            // NameSaleBox
            // 
            this.NameSaleBox.Location = new System.Drawing.Point(79, 19);
            this.NameSaleBox.Name = "NameSaleBox";
            this.NameSaleBox.ReadOnly = true;
            this.NameSaleBox.Size = new System.Drawing.Size(112, 20);
            this.NameSaleBox.TabIndex = 3;
            // 
            // OrderRadioButton
            // 
            this.OrderRadioButton.AutoSize = true;
            this.OrderRadioButton.Location = new System.Drawing.Point(35, 132);
            this.OrderRadioButton.Name = "OrderRadioButton";
            this.OrderRadioButton.Size = new System.Drawing.Size(156, 17);
            this.OrderRadioButton.TabIndex = 17;
            this.OrderRadioButton.TabStop = true;
            this.OrderRadioButton.Text = "Increase( Decrease default)";
            this.OrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sort By";
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "None(Default)",
            "ProductName",
            "Quantity",
            "Price"});
            this.SortComboBox.Location = new System.Drawing.Point(98, 105);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(113, 21);
            this.SortComboBox.TabIndex = 15;
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(136, 74);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 20);
            this.SearchBut.TabIndex = 14;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(19, 74);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(113, 20);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.Text = "Search";
            // 
            // DefaultBut
            // 
            this.DefaultBut.Location = new System.Drawing.Point(79, 47);
            this.DefaultBut.Name = "DefaultBut";
            this.DefaultBut.Size = new System.Drawing.Size(75, 21);
            this.DefaultBut.TabIndex = 12;
            this.DefaultBut.Text = "List All";
            this.DefaultBut.UseVisualStyleBackColor = true;
            this.DefaultBut.Click += new System.EventHandler(this.Test_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(147, 337);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(64, 23);
            this.DeleteBut.TabIndex = 10;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(79, 337);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(62, 23);
            this.EditBut.TabIndex = 9;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // InsertBut
            // 
            this.InsertBut.Location = new System.Drawing.Point(8, 337);
            this.InsertBut.Name = "InsertBut";
            this.InsertBut.Size = new System.Drawing.Size(65, 23);
            this.InsertBut.TabIndex = 8;
            this.InsertBut.Text = "Insert";
            this.InsertBut.UseVisualStyleBackColor = true;
            this.InsertBut.Click += new System.EventHandler(this.InsertBut_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(97, 299);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(114, 20);
            this.PriceBox.TabIndex = 7;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(97, 273);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(114, 20);
            this.QuantityBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(97, 194);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(114, 73);
            this.DescBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(97, 167);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(114, 20);
            this.NameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 433);
            this.Controls.Add(this.ProductsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).EndInit();
            this.ProductsBox.ResumeLayout(false);
            this.ProductsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGridView;
        private QuanLySieuThiDataSet quanLySieuThiDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private QuanLySieuThiDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox ProductsBox;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.Button InsertBut;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DefaultBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton OrderRadioButton;
        private System.Windows.Forms.TextBox IDSaleBox;
        private System.Windows.Forms.TextBox NameSaleBox;
    }
}