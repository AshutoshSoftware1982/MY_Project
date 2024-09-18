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
using Newtonsoft.Json;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class Client_Code : Form
    {
        public Client_Code()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Style_Master fr = (Style_Master)Application.OpenForms["Style_Master"];
            int row = e.RowIndex;
            fr.txt_ClientID.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
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
                    //label1.Visible = false;

                    //dataGridView1.EnableHeadersVisualStyles = false;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment.Equals(DataGridViewContentAlignment.MiddleLeft);

                }
            }
            catch (Exception)
            {

                //label1.Text = "Please check API";
            }
        }

        private void Client_Code_Load(object sender, EventArgs e)
        {

        }
    }
}
