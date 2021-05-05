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
    public partial class Form1 : Form
    {
        //configurationSettings and URL are apparently obsolete
        string URL = ConfigurationSettings.AppSettings["OurService"];
        public Form1()
        {
            InitializeComponent();
        }
        private static XElement RemoveAllNamespaces(XElement xmlDocument)
        {
            if (!xmlDocument.HasElements)
            {
                XElement xElement = new XElement(xmlDocument.Name.LocalName);
                xElement.Value = xmlDocument.Value;

                foreach (XAttribute attribute in xmlDocument.Attributes())
                    xElement.Add(attribute);

                return xElement;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }
        private void button_getAll_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wbc = new WebClient();
                wbc.Encoding = Encoding.UTF8;
                wbc.BaseAddress = URL;
                var result = wbc.DownloadString($"{URL}/GetAllCities");


                DataSet ds = new DataSet();

                ds.ReadXml(XmlReader.Create(new StringReader(result)));

                dataGridView1.DataSource = ds.Tables["CityDTO"];

                textBox1.Text = result;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            DialogResult decision = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try { 
                    WebClient wbc = new WebClient();
                    wbc.Encoding = Encoding.UTF8;
                    wbc.BaseAddress = URL;
                    WebRequest request = WebRequest.Create($"{URL}/DeleteCity/{Id}");
                    request.Method = "DELETE";
                    //request.ContentType = "application/Xml; charset=utf-8";
                    WebResponse responce = request.GetResponse();
                    Stream reader = responce.GetResponseStream();
                    StreamReader sReader = new StreamReader(reader);


                    textBox1.Text = responce.ToString();
                    //======
                    sReader.Close();
                    MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            AddCity AddCity = new AddCity();
            AddCity.Show();
        }
    }
}
