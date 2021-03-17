namespace WindowsFormsApp1
{
    partial class frmOrder
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
            this.txtBox_PostCode = new System.Windows.Forms.TextBox();
            this.txtBox_Region = new System.Windows.Forms.TextBox();
            this.txtBox_City = new System.Windows.Forms.TextBox();
            this.txtBox_country = new System.Windows.Forms.TextBox();
            this.txtBox_shipName = new System.Windows.Forms.TextBox();
            this.numericUpDown_empId = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_odate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_reqdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_shipDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_ShipVia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Freight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_custId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_empId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShipVia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Freight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_PostCode
            // 
            this.txtBox_PostCode.Location = new System.Drawing.Point(354, 119);
            this.txtBox_PostCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_PostCode.Name = "txtBox_PostCode";
            this.txtBox_PostCode.Size = new System.Drawing.Size(158, 20);
            this.txtBox_PostCode.TabIndex = 32;
            // 
            // txtBox_Region
            // 
            this.txtBox_Region.Location = new System.Drawing.Point(354, 93);
            this.txtBox_Region.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Region.Name = "txtBox_Region";
            this.txtBox_Region.Size = new System.Drawing.Size(158, 20);
            this.txtBox_Region.TabIndex = 31;
            // 
            // txtBox_City
            // 
            this.txtBox_City.Location = new System.Drawing.Point(354, 67);
            this.txtBox_City.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_City.Name = "txtBox_City";
            this.txtBox_City.Size = new System.Drawing.Size(158, 20);
            this.txtBox_City.TabIndex = 30;
            // 
            // txtBox_country
            // 
            this.txtBox_country.Location = new System.Drawing.Point(354, 146);
            this.txtBox_country.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_country.Name = "txtBox_country";
            this.txtBox_country.Size = new System.Drawing.Size(158, 20);
            this.txtBox_country.TabIndex = 29;
            // 
            // txtBox_shipName
            // 
            this.txtBox_shipName.Location = new System.Drawing.Point(354, 15);
            this.txtBox_shipName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_shipName.Name = "txtBox_shipName";
            this.txtBox_shipName.Size = new System.Drawing.Size(158, 20);
            this.txtBox_shipName.TabIndex = 28;
            // 
            // numericUpDown_empId
            // 
            this.numericUpDown_empId.Location = new System.Drawing.Point(100, 42);
            this.numericUpDown_empId.Name = "numericUpDown_empId";
            this.numericUpDown_empId.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_empId.TabIndex = 33;
            // 
            // dateTimePicker_odate
            // 
            this.dateTimePicker_odate.CustomFormat = "";
            this.dateTimePicker_odate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_odate.Location = new System.Drawing.Point(100, 68);
            this.dateTimePicker_odate.Name = "dateTimePicker_odate";
            this.dateTimePicker_odate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_odate.TabIndex = 34;
            // 
            // dateTimePicker_reqdate
            // 
            this.dateTimePicker_reqdate.CustomFormat = "";
            this.dateTimePicker_reqdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_reqdate.Location = new System.Drawing.Point(100, 94);
            this.dateTimePicker_reqdate.Name = "dateTimePicker_reqdate";
            this.dateTimePicker_reqdate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_reqdate.TabIndex = 34;
            // 
            // dateTimePicker_shipDate
            // 
            this.dateTimePicker_shipDate.CustomFormat = "";
            this.dateTimePicker_shipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_shipDate.Location = new System.Drawing.Point(100, 120);
            this.dateTimePicker_shipDate.Name = "dateTimePicker_shipDate";
            this.dateTimePicker_shipDate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_shipDate.TabIndex = 34;
            // 
            // numericUpDown_ShipVia
            // 
            this.numericUpDown_ShipVia.Location = new System.Drawing.Point(100, 146);
            this.numericUpDown_ShipVia.Name = "numericUpDown_ShipVia";
            this.numericUpDown_ShipVia.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ShipVia.TabIndex = 33;
            // 
            // numericUpDown_Freight
            // 
            this.numericUpDown_Freight.DecimalPlaces = 3;
            this.numericUpDown_Freight.Location = new System.Drawing.Point(100, 172);
            this.numericUpDown_Freight.Name = "numericUpDown_Freight";
            this.numericUpDown_Freight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Freight.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Order Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Required Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Shipped Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ship Via:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Freight:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ship Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ship Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ship City:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Ship Region:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ship Postal Code:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(354, 41);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(158, 20);
            this.textBox_Address.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Ship Country:";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(326, 195);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 37);
            this.button_add.TabIndex = 36;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_custId
            // 
            this.textBox_custId.Location = new System.Drawing.Point(99, 15);
            this.textBox_custId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_custId.Name = "textBox_custId";
            this.textBox_custId.Size = new System.Drawing.Size(121, 20);
            this.textBox_custId.TabIndex = 28;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 253);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_shipDate);
            this.Controls.Add(this.dateTimePicker_reqdate);
            this.Controls.Add(this.dateTimePicker_odate);
            this.Controls.Add(this.numericUpDown_Freight);
            this.Controls.Add(this.numericUpDown_ShipVia);
            this.Controls.Add(this.numericUpDown_empId);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.txtBox_PostCode);
            this.Controls.Add(this.txtBox_Region);
            this.Controls.Add(this.txtBox_City);
            this.Controls.Add(this.txtBox_country);
            this.Controls.Add(this.textBox_custId);
            this.Controls.Add(this.txtBox_shipName);
            this.Name = "frmOrder";
            this.Text = "Add New Order";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_empId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShipVia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Freight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_PostCode;
        private System.Windows.Forms.TextBox txtBox_Region;
        private System.Windows.Forms.TextBox txtBox_City;
        private System.Windows.Forms.TextBox txtBox_country;
        private System.Windows.Forms.TextBox txtBox_shipName;
        private System.Windows.Forms.NumericUpDown numericUpDown_empId;
        private System.Windows.Forms.DateTimePicker dateTimePicker_odate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reqdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_shipDate;
        private System.Windows.Forms.NumericUpDown numericUpDown_ShipVia;
        private System.Windows.Forms.NumericUpDown numericUpDown_Freight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_custId;
    }
}