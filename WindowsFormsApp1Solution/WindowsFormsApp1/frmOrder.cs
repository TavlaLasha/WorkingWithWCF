using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.OrderService;

namespace WindowsFormsApp1
{
    public partial class frmOrder : Form
    {
        OrderService.SalesManagementClient od = new OrderService.SalesManagementClient();
        int? Id;
        public frmOrder()
        {
            InitializeComponent();
            Id = null;
        }
        public frmOrder(int id)
        {
            InitializeComponent();
            Id = id;
            Text = "Update Order";
            button_add.Text = "Update";
            FillForm(id);
        }
        

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDTO o = new OrderDTO();

                o.CustomerID = textBox_custId.Text;
                o.EmployeeID = Convert.ToInt32(numericUpDown_empId.Value);
                o.OrderDate = dateTimePicker_odate.Value;
                o.RequiredDate = dateTimePicker_reqdate.Value;
                o.ShippedDate = dateTimePicker_shipDate.Value;
                o.ShipVia = Convert.ToInt32(numericUpDown_ShipVia.Value);
                o.Freight = numericUpDown_Freight.Value;
                o.ShipName = txtBox_shipName.Text;
                o.ShipAddress = textBox_Address.Text;
                o.ShipCity = txtBox_City.Text;
                o.ShipRegion = txtBox_Region.Text;
                o.ShipPostalCode = txtBox_PostCode.Text;
                o.ShipCountry = txtBox_country.Text;

                bool JobDone = od.AddOrder(o);
                if (!JobDone)
                    throw new Exception("Failed to save order");

                MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void FillForm(int id)
        {
            try
            {
                OrderDTO i = null;
                try
                {
                    i = od.GetOrder(id);
                }
                catch (Exception ee)
                {// log.message(ee.Message);
                    throw new Exception("Technical error. Please Try again later.");
                }

                if (i != null)
                {
                    textBox_custId.Text = i.CustomerID;
                    numericUpDown_empId.Value = Convert.ToInt32(i.EmployeeID);
                    dateTimePicker_odate.Value = Convert.ToDateTime(i.OrderDate);
                    dateTimePicker_reqdate.Value = Convert.ToDateTime(i.RequiredDate);
                    dateTimePicker_shipDate.Value = Convert.ToDateTime(i.ShippedDate);
                    numericUpDown_ShipVia.Value = Convert.ToInt32(i.ShipVia);
                    numericUpDown_Freight.Value = Convert.ToDecimal(i.Freight);
                    txtBox_shipName.Text = i.ShipName;
                    textBox_Address.Text = i.ShipAddress;
                    txtBox_City.Text = i.ShipCity;
                    txtBox_Region.Text = i.ShipRegion;
                    txtBox_PostCode.Text = i.ShipPostalCode;
                    txtBox_country.Text = i.ShipCountry;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
