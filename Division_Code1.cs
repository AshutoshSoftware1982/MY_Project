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
    public partial class Division_Code1 : Form
    {
        public Division_Code1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Division_Code1_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Size_Range fr = (Size_Range)Application.OpenForms["Size_Range"];
            int row = e.RowIndex;
            fr.txt_Division.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}
