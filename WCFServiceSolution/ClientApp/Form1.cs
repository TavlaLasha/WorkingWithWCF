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
using System.IO;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        //[Obsolete]
        string CityURL = ConfigurationSettings.AppSettings["CityService"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button_getAll_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wbc = new WebClient();
                wbc.Encoding = Encoding.UTF8;
                wbc.BaseAddress = CityURL;
                var result = wbc.DownloadString($"{CityURL}/GetAllCities");
                Response<List<City>> ct = JsonConvert.DeserializeObject<Response<List<City>>>(result);
                if (ct.IsError)
                    throw new Exception(ct.ErrorMessage);
                dataGridView1.DataSource = ct.Data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FrmCity fcity = new FrmCity();
            fcity.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Name = "ID";
            var row = dataGridView1.CurrentRow;
            int Id = (int)row.Cells["ID"].Value;
            FrmCity fcity = new FrmCity(Id);
            fcity.Show();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Name = "ID";
            var row = dataGridView1.CurrentRow;
            int Id = (int)row.Cells["ID"].Value;
            DialogResult decision = MessageBox.Show("Are you sure?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    WebClient wbc = new WebClient();
                    wbc.Encoding = Encoding.UTF8;
                    wbc.BaseAddress = CityURL;
                    WebRequest request = WebRequest.Create($"{CityURL}/DeleteCity/{Id}");
                    request.Method = "DELETE";
                    request.ContentType = "application/json; charset=utf-8";
                    WebResponse responce = request.GetResponse();
                    Stream reader = responce.GetResponseStream();
                    StreamReader sReader = new StreamReader(reader);

                    Response<bool> cot = JsonConvert.DeserializeObject<Response<bool>>(sReader.ReadToEnd());
                    if (cot.IsError)
                        throw new Exception(cot.ErrorMessage);

                    sReader.Close();
                    MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            button_edit.Enabled = true;
            button_delete.Enabled = true;
        }
    }
}
