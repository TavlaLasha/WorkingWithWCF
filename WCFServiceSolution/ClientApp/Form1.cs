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
                Response<City> ct = JsonConvert.DeserializeObject<Response<City>>(result);
                if (ct.IsError)
                    throw new Exception(ct.ErrorMessage);
                dataGridView1.DataSource = ct.Data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
