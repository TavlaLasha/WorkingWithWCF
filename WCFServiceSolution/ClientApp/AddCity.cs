using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using ClientApp.Models;
using System.Web.Script.Serialization;
using WCFService.ServiceModels;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ClientApp
{
    public partial class AddCity : Form
    {
        string URL = ConfigurationSettings.AppSettings["OurService"];
        City ct;
        //City ct = new City();
        public AddCity()
        {
            InitializeComponent();
            //ct = new City();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CityName = textBox1.Text;
            int CountryId = Convert.ToInt32(textBox2.Text);

            try
            {
                //AddCity ct = new AddCity();
                ct = new City();
                ct.CityName = CityName;
                ct.CountryId = CountryId;

                WebClient wbc = new WebClient();
                wbc.Encoding = Encoding.UTF8;
                wbc.BaseAddress = URL;

                //DataSet ct = new DataSet();

                //string output = JsonConvert.SerializeObject(ct);
                //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(ct.GetType());

                string output = ct.ToString();

                WebRequest request;
                request = WebRequest.Create($"{URL}/AddNewCity");
                request.Method = "POST";
                request.ContentLength = output.Length;
                request.ContentType = "application/json; charset=utf-8";

                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(output);
                }

                WebResponse responce = request.GetResponse();
                Stream reader = responce.GetResponseStream();
                StreamReader sReader = new StreamReader(reader);


                textBox3.Text = responce.ToString();
                //======
                sReader.Close();
                    MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
