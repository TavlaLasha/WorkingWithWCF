using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFService.EF;
using WCFService.ServiceModels;

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
                try
                {
                    using (VoiceVoteDB db = new VoiceVoteDB())
                    {
                        City comp = new City()
                        {
                            City_Name = textBox1.Text,
                            Country_Id = (from c in db.Countries
                                          where c.Country_Name == comboBox1.Text
                                          select c.Country_Id).FirstOrDefault()
                        };
                        string output = JsonConvert.SerializeObject(comp);

                        string strUri = $"{URL}/AddNewCity";
                        Uri uri = new Uri(strUri);
                        WebRequest request = WebRequest.Create(uri);
                        request.Method = "POST";
                        request.ContentLength = output.Length;
                        request.ContentType = "application/json; charset=utf-8";

                        string serOut = JsonConvert.SerializeObject(comp);

                        using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                        {
                            writer.Write(serOut);
                        }

                        WebResponse responce = request.GetResponse();
                        Stream reader = responce.GetResponseStream();

                        StreamReader sReader = new StreamReader(reader);
                        string outResult = sReader.ReadToEnd();
                        sReader.Close();
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
