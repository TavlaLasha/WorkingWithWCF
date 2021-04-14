using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using ClientApp.Models;
using System.Web.Script.Serialization;
using WCFService.ServiceModels;
using Newtonsoft.Json;
using WCFService.EF;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        string URL = ConfigurationSettings.AppSettings["OurService"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button_getAll_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wbc = new WebClient();
                wbc.Encoding = UTF8Encoding.UTF8;
                wbc.BaseAddress = URL;
                var result = wbc.DownloadString($"{URL}/GetAllCities");
                Response<ClientApp.Models.City> ct = JsonConvert.DeserializeObject<Response<ClientApp.Models.City>>(result);
                if (ct.IsError)
                    throw new Exception(ct.ErrorMessage);
                dataGridView1.DataSource = ct.Data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddCity f = new frmAddCity();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.CurrentRow;
                int Id = (int)row.Cells["CityId"].Value;
                if (MessageBox.Show("Are You Sure?", "Question About Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (VoiceVoteDB db = new VoiceVoteDB())
                    {
                        if (!db.Cities.Any(i => i.City_Id == Id))
                            throw new Exception("Product Not Found!");

                        WCFService.EF.City p = db.Cities.Where(i => i.City_Id == Id).First();
                        db.Cities.Remove(p);
                        db.SaveChanges();
                    }
                    MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int Id = (int)row.Cells["CityId"].Value;
            frmEditCity frm = new frmEditCity(Id);
            frm.Show();
        }
    }
}
