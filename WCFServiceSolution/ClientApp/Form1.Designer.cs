namespace ClientApp
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_getAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.AddCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_getAll
            // 
            this.button_getAll.Location = new System.Drawing.Point(444, 70);
            this.button_getAll.Name = "button_getAll";
            this.button_getAll.Size = new System.Drawing.Size(75, 23);
            this.button_getAll.TabIndex = 1;
            this.button_getAll.Text = "Get All";
            this.button_getAll.UseVisualStyleBackColor = true;
            this.button_getAll.Click += new System.EventHandler(this.button_getAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 348);
            this.textBox1.TabIndex = 2;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(444, 191);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // AddCity
            // 
            this.AddCity.Location = new System.Drawing.Point(444, 109);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(75, 23);
            this.AddCity.TabIndex = 4;
            this.AddCity.Text = "Add City";
            this.AddCity.UseVisualStyleBackColor = true;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 372);
            this.Controls.Add(this.AddCity);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_getAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_getAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button AddCity;
    }
}

