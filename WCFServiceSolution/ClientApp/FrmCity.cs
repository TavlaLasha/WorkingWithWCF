using ClientApp.Models;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFService.ServiceModels;

namespace ClientApp
{
    public partial class FrmCity : Form
    {
        public int? Id;
        string CityURL = ConfigurationSettings.AppSettings["CityService"];
        string CountryURL = ConfigurationSettings.AppSettings["CountryService"];
        WebClient wbc = new WebClient();
        City ct;
        public FrmCity()
        {
            InitializeComponent();
            FillCombo();
        }
        public FrmCity(int id)
        {
            InitializeComponent();
            Id = id;
            Text = "Update City";
            FillCombo();
            FillForm();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Id.HasValue)
                    ct = new City();
                else
                    ct.CityId = Id.HasValue?Id.Value:0;

                ct.CityName = textBox_Name.Text;
                ct.CountryId = Convert.ToInt32(comboBox_Country.SelectedValue);
                
                string output = JsonConvert.SerializeObject(ct);
                WebRequest request;
                if (!Id.HasValue)
                {
                    request = WebRequest.Create($"{CityURL}/AddNewCity");
                    request.Method = "POST";
                }
                else
                {
                    request = WebRequest.Create($"{CityURL}/UpdateCity");
                    request.Method = "PUT";
                }
                request.ContentLength = output.Length;
                request.ContentType = "application/json; charset=utf-8";
                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(output);
                }
                WebResponse responce = request.GetResponse();
                Stream reader = responce.GetResponseStream();
                StreamReader sReader = new StreamReader(reader);

                Response<bool> cot = JsonConvert.DeserializeObject<Response<bool>>(sReader.ReadToEnd());
                if (cot.IsError)
                    throw new Exception(cot.ErrorMessage);

                sReader.Close();

                string info = (Id.HasValue) ? "Updated" : "Added";
                MessageBox.Show($"City Has Been Successfully {info}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
        public void FillForm()
        {
            string result = wbc.DownloadString($"{CityURL}/GetCity/{Id}");
            Response<City> cty = JsonConvert.DeserializeObject<Response<City>>(result);
            if (cty.IsError)
                throw new Exception(cty.ErrorMessage);
            ct = cty.Data;
            textBox_Name.Text = cty.Data.CityName;
            comboBox_Country.SelectedIndex = cty.Data.CountryId-1;
        }
        public void FillCombo()
        {
            try
            {
                var result = wbc.DownloadString($"{CountryURL}/GetAllCountries");
                Response<List<Country>> cot = JsonConvert.DeserializeObject<Response<List<Country>>>(result);
                if (cot.IsError)
                    throw new Exception(cot.ErrorMessage);
                comboBox_Country.DataSource = new BindingSource(cot.Data, null);
                comboBox_Country.DisplayMember = "CountryName";
                comboBox_Country.ValueMember = "CountryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
