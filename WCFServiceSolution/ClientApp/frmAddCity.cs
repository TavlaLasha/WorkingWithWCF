using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFService.EF;

namespace ClientApp
{
    public partial class frmAddCity : Form
    {
        public frmAddCity()
        {
            InitializeComponent();
            FillCombos();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    
                    using (VoiceVoteDB db = new VoiceVoteDB())
                    {
                        City ct = new City();
                        ct.City_Name = textBox1.Text;
                        ct.Country_Id = (from c in db.Countries
                                         where c.Country_Name == comboBox1.Text
                                         select c.Country_Id).FirstOrDefault();
                        
                        db.Cities.Add(ct);
                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("ოპერაცია წარმატებით დასრულდა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillCombos()
        {
            using (VoiceVoteDB db = new VoiceVoteDB())
            {
                comboBox1.DataSource = db.Countries.Select(i => i.Country_Name).ToList();
            }
        }
    }
}
