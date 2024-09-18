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
    public partial class Content_Data : Form
    {
        public Content_Data()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Content_Data_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/content/GetContent");
                var consumeapi = hc.GetAsync("GetContent");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<ContentModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<ContentModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<ContentModel>().ToList();
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
    }
}
