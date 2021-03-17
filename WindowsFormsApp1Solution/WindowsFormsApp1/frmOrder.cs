using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                bool JobDone = od.SaveOrder(
                    Id,
                    textBox_custId.Text,
                    Convert.ToInt32(numericUpDown_empId.Value),
                    dateTimePicker_odate.Value,
                    dateTimePicker_reqdate.Value,
                    dateTimePicker_shipDate.Value,
                    Convert.ToInt32(numericUpDown_ShipVia.Value),
                    numericUpDown_Freight.Value,
                    txtBox_shipName.Text,
                    textBox_Address.Text,
                    txtBox_City.Text,
                    txtBox_Region.Text,
                    txtBox_PostCode.Text,
                    txtBox_country.Text
                    );
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
            var inf = od.GetOrder(id);
            foreach(var i in inf)
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
    }
}
