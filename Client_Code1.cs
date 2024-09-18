using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Client_Code1 : Form
    {
        public Client_Code1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Client_Code1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Size_Range fr = (Size_Range)Application.OpenForms["Size_Range"];
            int row = e.RowIndex;
            fr.txt_ClientCode.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Size_Range fr = (Size_Range)Application.OpenForms["Size_Range"];
            int row = e.RowIndex;
            fr.txt_ClientCode.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}
