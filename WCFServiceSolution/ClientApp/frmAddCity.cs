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
using WCFService.EF;
using WCFService.ServiceModels;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace ClientApp
{
    public partial class frmAddCity : Form
    {
        string URL = ConfigurationSettings.AppSettings["OurService"];
        public frmAddCity()
        {
            InitializeComponent();
            FillCombos();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {


                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    CityDTO cty = new CityDTO()
                    {
                        CityName = textBox1.Text,
                        CountryId = (from c in db.Countries
                                     where c.Country_Name == comboBox1.Text
                                     select c.Country_Id).FirstOrDefault()
                    };

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
