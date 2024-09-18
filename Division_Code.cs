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
    public partial class Division_Code : Form
    {
        public Division_Code()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Style_Master fr = (Style_Master)Application.OpenForms["Style_Master"];
            int row = e.RowIndex;
            fr.txt_DivisionCode.Text = Convert.ToString(dataGridView1[0, row].Value);
            fr.txt_DivisionCode1.Text = Convert.ToString(dataGridView1[1, row].Value);
            this.Hide();
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
    }
}
