using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference2;
namespace WindowsFormsApp1
{
    public partial class frmAddSupplier : Form
    {
        ServiceReference2.CatalogManagementClient sv = new ServiceReference2.CatalogManagementClient();
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDTO s = new SupplierDTO();

                s.CompName = txtBox_compName.Text;
                s.ContName = txtBox_contName.Text;
                s.ContTitle = txtBox_contTitle.Text;
                s.Addrss = txtBox_address.Text;
                s.Ct = txtBox_city.Text;
                s.Rgn = txtBox_region.Text;
                s.PstCode = txtBox_postalCode.Text;
                s.Cntry = txtBox_country.Text;
                s.Phn = txtBox_phone.Text;
                s.Fx = txtBox_fax.Text;
                s.HmPage = txtBox_homePage.Text;
                sv.AddSupplier(s);
                bool JobDone = sv.AddSupplier(s);
                if (!JobDone)
                    throw new Exception("Failed to save supplier");

                MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
