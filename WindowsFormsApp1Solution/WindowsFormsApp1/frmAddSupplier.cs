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
                string CompName = txtBox_compName.Text;
                string ContName = txtBox_contName.Text;
                string ContTitle = txtBox_contTitle.Text;
                string Addrss = txtBox_address.Text;
                string ct = txtBox_city.Text;
                string Rgn = txtBox_region.Text;
                string PstCode = txtBox_postalCode.Text;
                string Cntry = txtBox_country.Text;
                string Phn = txtBox_phone.Text;
                string Fx = txtBox_fax.Text;
                string HmPage = txtBox_homePage.Text;
                sv.AddSupplier(CompName, ContName, ContTitle, Addrss, ct, Rgn, PstCode, Cntry, Phn, Fx, HmPage);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
