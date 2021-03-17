using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceReference2.CatalogManagementClient sv = new ServiceReference2.CatalogManagementClient();
        OrderService.SalesManagementClient od = new OrderService.SalesManagementClient();
        string WorkingWith;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(numericUpDown1.Value);
                if (WorkingWith == "Supplier")
                {
                    var r = sv.GetSupplier(Id);
                    if (r == null)
                        throw new Exception("Supplier not found!");
                    MessageBox.Show($"Supplier with an id of {Id} - {r.CompName}.");
                }
                else if(WorkingWith == "Order")
                {
                    var o = od.GetOrder(Id);
                    if (!o.Any())
                        throw new Exception("Order not found!");

                    dataGridView1.DataSource = o;
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (WorkingWith == "Supplier")
                {
                    var ls = sv.GetAllSuppliers();
                    dataGridView1.DataSource = ls;
                }
                else if (WorkingWith == "Order")
                {
                    var ods = od.GetAllOrder();
                    dataGridView1.DataSource = ods;
                }
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WorkingWith == "Supplier")
            {
                frmAddSupplier frm = new frmAddSupplier();
                frm.Show();
            }
            else if (WorkingWith == "Order")
            {
                frmOrder ordfrm = new frmOrder();
                ordfrm.Show();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.CurrentRow;
                int Id = (int)row.Cells["Id"].Value;
                bool JobDone = false;
                if (WorkingWith == "Supplier")
                {
                    sv.DeleteSupplier(Id);
                    JobDone = true;
                }
                else if (WorkingWith == "Order")
                {
                    JobDone = od.DeleteOrder(Id);
                }
                if (!JobDone)
                    throw new Exception("Delete Failed");
                MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int Id = (int)row.Cells["Id"].Value;

            if (WorkingWith == "Supplier")
            {

            }
            else if (WorkingWith == "Order")
            {
                frmOrder ordfrm = new frmOrder(Id);
                ordfrm.Show();
            } 
        }
        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assignWork("Supplier");
        }
        private void assignWork(string work)
        {
            WorkingWith = work;
            numericUpDown1.Enabled = true;
            btn_get.Enabled = true;
            btn_getall.Enabled = true;
            btn_add.Enabled = true;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assignWork("Order");
        }
    }
}
