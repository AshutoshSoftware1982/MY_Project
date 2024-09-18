using Newtonsoft.Json;
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
    public partial class Division2 : Form
    {
        public Division2()
        {
            InitializeComponent();
        }

        private void Division2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/Division/GetDivisonCode");
                var consumeapi = hc.GetAsync("GetDivisonCode");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<DivisionModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<DivisionModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<DivisionModel>().ToList();
                    dataGridView1.DataSource = MyDeserialisedObject;
                    //label1.Visible = false;

                    

                }
            }
            catch (Exception)
            {

                //label1.Text = "Please check API";
            }

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SizeExplosion fr = (SizeExplosion)Application.OpenForms["SizeExplosion"];
            int row = e.RowIndex;
            fr.textBox3.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}
