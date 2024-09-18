﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Client_Code4 : Form
    {
        public Client_Code4()
        {
            InitializeComponent();
        }

        private void Client_Code4_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/Customer/GetClientCode");
                var consumeapi = hc.GetAsync("GetClientCode");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<ClientModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<ClientModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<ClientModel>().ToList();
                    dataGridView1.DataSource = MyDeserialisedObject;
                 }
            }
            catch (Exception)
            {

                MessageBox.Show("Network Issue Please Check API");
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClientColor fr = (ClientColor)Application.OpenForms["ClientColor"];
            int row = e.RowIndex;
            fr.txt_ClientID.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}
