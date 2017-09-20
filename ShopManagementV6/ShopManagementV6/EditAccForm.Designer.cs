namespace ShopManagementV6
{
    partial class EditAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccForm));
            this.UserBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.DesBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(131, 62);
            this.UserBox.Name = "UserBox";
            this.UserBox.ReadOnly = true;
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(131, 96);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(131, 130);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 2;
            // 
            // DesBox
            // 
            this.DesBox.Location = new System.Drawing.Point(131, 156);
            this.DesBox.Multiline = true;
            this.DesBox.Name = "DesBox";
            this.DesBox.Size = new System.Drawing.Size(100, 42);
            this.DesBox.TabIndex = 3;
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Location = new System.Drawing.Point(131, 204);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirthBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descriptions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DateOfBirth";
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(43, 261);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(75, 23);
            this.EditBut.TabIndex = 10;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = true;
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(145, 261);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 11;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edit Account";
            // 
            // EditAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateOfBirthBox);
            this.Controls.Add(this.DesBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UserBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAccForm";
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.EditAccForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox DesBox;
        private System.Windows.Forms.TextBox DateOfBirthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label label6;
    }
}