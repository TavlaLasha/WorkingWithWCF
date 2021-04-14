using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFService.EF;
using WCFService.ServiceModels;

namespace ClientApp
{
    public partial class frmEditCity : Form
    {
        public int? Id;
        public frmEditCity(int id)
        {
            InitializeComponent();
            FillCombos();
            FillForm(id);
            this.Id = id;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (VoiceVoteDB db = new VoiceVoteDB())
            {
                try
                {
                    var ct = (from p in db.Cities
                              join s in db.Countries on p.Country_Id equals s.Country_Id
                              where p.City_Id == Id
                              select p).FirstOrDefault();
                    ct.City_Name = textBox1.Text;
                    ct.Country_Id = (from c in db.Countries
                                     where c.Country_Name == comboBox1.Text
                                     select c.Country_Id).FirstOrDefault();

                    db.SaveChanges();
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
        }
        public void FillCombos()
        {
            using (VoiceVoteDB db = new VoiceVoteDB())
            {
                comboBox1.DataSource = db.Countries.Select(i => i.Country_Name).ToList();
            }
        }
        public void FillForm(int id)
        {
            using (VoiceVoteDB db = new VoiceVoteDB())
            {
                try
                {
                    var pd = (from p in db.Cities
                              join s in db.Countries on p.Country_Id equals s.Country_Id
                              where p.City_Id == id
                              select p).ToList();
                    foreach (City i in pd)
                    {
                        textBox1.Text = i.City_Name;
                        comboBox1.SelectedIndex = comboBox1.FindString(i.Country.Country_Name);

                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
