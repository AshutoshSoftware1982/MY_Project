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
    public partial class Division_Code2 : Form
    {
        public Division_Code2()
        {
            InitializeComponent();
        }

        private void Division_Code2_Load(object sender, EventArgs e)
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
                    



                }
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Session fr = (Session)Application.OpenForms["Session"];
            int row = e.RowIndex;
            fr.txt_Division.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}
