
namespace WindowsFormsApp1
{
    partial class frmAddSupplier
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txtBox_compName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_contName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_contTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_fax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_country = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox_postalCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_region = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_homePage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(226, 345);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtBox_compName
            // 
            this.txtBox_compName.Location = new System.Drawing.Point(159, 20);
            this.txtBox_compName.Name = "txtBox_compName";
            this.txtBox_compName.Size = new System.Drawing.Size(210, 22);
            this.txtBox_compName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // txtBox_contName
            // 
            this.txtBox_contName.Location = new System.Drawing.Point(159, 48);
            this.txtBox_contName.Name = "txtBox_contName";
            this.txtBox_contName.Size = new System.Drawing.Size(210, 22);
            this.txtBox_contName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Name";
            // 
            // txtBox_contTitle
            // 
            this.txtBox_contTitle.Location = new System.Drawing.Point(159, 76);
            this.txtBox_contTitle.Name = "txtBox_contTitle";
            this.txtBox_contTitle.Size = new System.Drawing.Size(210, 22);
            this.txtBox_contTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact Title";
            // 
            // txtBox_address
            // 
            this.txtBox_address.Location = new System.Drawing.Point(159, 104);
            this.txtBox_address.Name = "txtBox_address";
            this.txtBox_address.Size = new System.Drawing.Size(210, 22);
            this.txtBox_address.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txtBox_city
            // 
            this.txtBox_city.Location = new System.Drawing.Point(159, 132);
            this.txtBox_city.Name = "txtBox_city";
            this.txtBox_city.Size = new System.Drawing.Size(210, 22);
            this.txtBox_city.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fax";
            // 
            // txtBox_fax
            // 
            this.txtBox_fax.Location = new System.Drawing.Point(159, 272);
            this.txtBox_fax.Name = "txtBox_fax";
            this.txtBox_fax.Size = new System.Drawing.Size(210, 22);
            this.txtBox_fax.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone";
            // 
            // txtBox_phone
            // 
            this.txtBox_phone.Location = new System.Drawing.Point(159, 244);
            this.txtBox_phone.Name = "txtBox_phone";
            this.txtBox_phone.Size = new System.Drawing.Size(210, 22);
            this.txtBox_phone.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Country";
            // 
            // txtBox_country
            // 
            this.txtBox_country.Location = new System.Drawing.Point(159, 216);
            this.txtBox_country.Name = "txtBox_country";
            this.txtBox_country.Size = new System.Drawing.Size(210, 22);
            this.txtBox_country.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Postal Code";
            // 
            // txtBox_postalCode
            // 
            this.txtBox_postalCode.Location = new System.Drawing.Point(159, 188);
            this.txtBox_postalCode.Name = "txtBox_postalCode";
            this.txtBox_postalCode.Size = new System.Drawing.Size(210, 22);
            this.txtBox_postalCode.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Region";
            // 
            // txtBox_region
            // 
            this.txtBox_region.Location = new System.Drawing.Point(159, 160);
            this.txtBox_region.Name = "txtBox_region";
            this.txtBox_region.Size = new System.Drawing.Size(210, 22);
            this.txtBox_region.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Home Page";
            // 
            // txtBox_homePage
            // 
            this.txtBox_homePage.Location = new System.Drawing.Point(159, 300);
            this.txtBox_homePage.Name = "txtBox_homePage";
            this.txtBox_homePage.Size = new System.Drawing.Size(210, 22);
            this.txtBox_homePage.TabIndex = 21;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 408);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBox_homePage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_fax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_country);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBox_postalCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox_region);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_contTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_contName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_compName);
            this.Name = "frmAddSupplier";
            this.Text = "frmAddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtBox_compName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_contName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_contTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_fax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_country;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox_postalCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_region;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_homePage;
    }
}