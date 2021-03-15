using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceReference2.CatalogManagementClient sv = new ServiceReference2.CatalogManagementClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = Convert.ToInt32(numericUpDown1.Value);
                
                ServiceReference2.Suppliers r = sv.GetSupplier(supplierId);
                if (r != null)
                {

                    MessageBox.Show($"Supplier with an id of {supplierId} - {r.CompName}.");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ls = sv.GetAllSuppliers();
                dataGridView1.DataSource = ls;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAddSupplier frm = new frmAddSupplier();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.CurrentRow;
                int Id = (int)row.Cells["Id"].Value;
                sv.DeleteSupplier(Id);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
