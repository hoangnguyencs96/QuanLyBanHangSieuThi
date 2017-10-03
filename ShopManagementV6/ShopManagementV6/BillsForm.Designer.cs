namespace ShopManagementV6
{
    partial class BillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsForm));
            this.ProductBillGridView = new System.Windows.Forms.DataGridView();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.SpecificDay = new System.Windows.Forms.DateTimePicker();
            this.CountBut = new System.Windows.Forms.Button();
            this.IDSaleBox = new System.Windows.Forms.TextBox();
            this.NameSaleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewBillsBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdvanceBox = new System.Windows.Forms.TextBox();
            this.AdvanceBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBillGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductBillGridView
            // 
            this.ProductBillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductBillGridView.Location = new System.Drawing.Point(468, 262);
            this.ProductBillGridView.Name = "ProductBillGridView";
            this.ProductBillGridView.Size = new System.Drawing.Size(463, 173);
            this.ProductBillGridView.TabIndex = 0;
            this.ProductBillGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductBillGridView_MouseClick);
            // 
            // BillGridView
            // 
            this.BillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Location = new System.Drawing.Point(468, 55);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.Size = new System.Drawing.Size(463, 173);
            this.BillGridView.TabIndex = 1;
            this.BillGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BillGridView_RowHeaderMouseClick);
            this.BillGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BillGridView_MouseClick);
            // 
            // SpecificDay
            // 
            this.SpecificDay.Location = new System.Drawing.Point(115, 120);
            this.SpecificDay.Name = "SpecificDay";
            this.SpecificDay.Size = new System.Drawing.Size(200, 20);
            this.SpecificDay.TabIndex = 2;
            // 
            // CountBut
            // 
            this.CountBut.Location = new System.Drawing.Point(331, 166);
            this.CountBut.Name = "CountBut";
            this.CountBut.Size = new System.Drawing.Size(75, 20);
            this.CountBut.TabIndex = 3;
            this.CountBut.Text = "Count";
            this.CountBut.UseVisualStyleBackColor = true;
            this.CountBut.Click += new System.EventHandler(this.CountBut_Click);
            // 
            // IDSaleBox
            // 
            this.IDSaleBox.Location = new System.Drawing.Point(805, 12);
            this.IDSaleBox.Name = "IDSaleBox";
            this.IDSaleBox.ReadOnly = true;
            this.IDSaleBox.Size = new System.Drawing.Size(20, 20);
            this.IDSaleBox.TabIndex = 4;
            // 
            // NameSaleBox
            // 
            this.NameSaleBox.Location = new System.Drawing.Point(831, 12);
            this.NameSaleBox.Name = "NameSaleBox";
            this.NameSaleBox.ReadOnly = true;
            this.NameSaleBox.Size = new System.Drawing.Size(100, 20);
            this.NameSaleBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Day";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(115, 166);
            this.CountBox.Name = "CountBox";
            this.CountBox.ReadOnly = true;
            this.CountBox.Size = new System.Drawing.Size(200, 20);
            this.CountBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Earn";
            // 
            // ViewBillsBut
            // 
            this.ViewBillsBut.Location = new System.Drawing.Point(144, 56);
            this.ViewBillsBut.Name = "ViewBillsBut";
            this.ViewBillsBut.Size = new System.Drawing.Size(163, 37);
            this.ViewBillsBut.TabIndex = 9;
            this.ViewBillsBut.Text = "View All Bills";
            this.ViewBillsBut.UseVisualStyleBackColor = true;
            this.ViewBillsBut.Click += new System.EventHandler(this.ViewBillsBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdvanceBox);
            this.groupBox1.Controls.Add(this.AdvanceBut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ViewButton);
            this.groupBox1.Controls.Add(this.SearchBut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.ViewBillsBut);
            this.groupBox1.Controls.Add(this.CountBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SpecificDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CountBut);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 434);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills";
            // 
            // AdvanceBox
            // 
            this.AdvanceBox.Location = new System.Drawing.Point(215, 380);
            this.AdvanceBox.Name = "AdvanceBox";
            this.AdvanceBox.ReadOnly = true;
            this.AdvanceBox.Size = new System.Drawing.Size(100, 20);
            this.AdvanceBox.TabIndex = 21;
            // 
            // AdvanceBut
            // 
            this.AdvanceBut.Location = new System.Drawing.Point(125, 378);
            this.AdvanceBut.Name = "AdvanceBut";
            this.AdvanceBut.Size = new System.Drawing.Size(75, 23);
            this.AdvanceBut.TabIndex = 20;
            this.AdvanceBut.Text = "Count";
            this.AdvanceBut.UseVisualStyleBackColor = true;
            this.AdvanceBut.Click += new System.EventHandler(this.AdvanceBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Time";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Location = new System.Drawing.Point(173, 334);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndTimePicker.TabIndex = 17;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Location = new System.Drawing.Point(173, 308);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartTimePicker.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search Products are sold";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(331, 120);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 20);
            this.ViewButton.TabIndex = 14;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(331, 268);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 20);
            this.SearchBut.TabIndex = 13;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Advance Count";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(164, 268);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(143, 20);
            this.SearchBox.TabIndex = 11;
            this.SearchBox.Text = "Type search text here!";
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bills";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bills Details";
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 449);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameSaleBox);
            this.Controls.Add(this.IDSaleBox);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.ProductBillGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillsForm";
            this.Text = "Bills Management";
            ((System.ComponentModel.ISupportInitialize)(this.ProductBillGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductBillGridView;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.DateTimePicker SpecificDay;
        private System.Windows.Forms.Button CountBut;
        private System.Windows.Forms.TextBox IDSaleBox;
        private System.Windows.Forms.TextBox NameSaleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewBillsBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdvanceBox;
        private System.Windows.Forms.Button AdvanceBut;
    }
}