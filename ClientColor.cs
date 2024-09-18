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
    public partial class ClientColor : Form
    {
        public ClientColor()
        {
            InitializeComponent();
            
        }

        private void ClientColor_Load(object sender, EventArgs e)
        {
            Color_Code();
            comboBox1.Text = "S";
            textBox5.Text = Form1.SetValueForText1;
        }
        public void Color_Code()
        {
            string[] color = { "S", "D" };
            for (int i = 0; i < color.Length; i++)
            {
                comboBox1.Items.Add(color[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/Size_Color/Get_Color");
                var consumeapi = hc.GetAsync("Get_Color");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<Size_ColorModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<Size_ColorModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<Size_ColorModel>().ToList();
                    dataGridView1.DataSource = MyDeserialisedObject;
                    dataGridView1.Columns["TimeCreated"].DefaultCellStyle.Format = "HH:mm:ss";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Network Issue please check API");
            }
        }

        private void txt_ClientID_DoubleClick(object sender, EventArgs e)
        {
            Client_Code4 client_Code = new Client_Code4();
            client_Code.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ColorsModel size = new ColorsModel();
            size.ClientID = txt_ClientID.Text;
            size.Color = txt_Color.Text;
            size.ColorFlag = comboBox1.Text;
            size.ShortColorDesc = txt_ShortColorDesc.Text;
            size.ColorDesc = txt_ColorDescs.Text;
            size.ColorGroup = txt_ColorGroup.Text;
            size.NRFColor = txt_NRFColor.Text;
            size.ColorRef = txt_ColorRef.Text;
            size.ColorStandard = txt_ColorStandard.Text;
            size.ColorName = txt_ColorName.Text;
            size.LegacyColor = txt_LegacyColor.Text;
            size.ColorUDF01 = txt_UDF01.Text;
            size.ColorUDF02 = txt_UDF02.Text;
            size.ColorUDF03 = txt_UDF03.Text;
            size.ColorUDF04 = txt_UDF04.Text;
            size.ColorUDF05 = txt_UDF05.Text;
            size.C = textBox1.Text;
            size.Y = textBox2.Text;
            size.M = textBox3.Text;
            size.K = textBox4.Text;
            size.NRFColorList = txt_NRFCOLORLIST.Text;
            size.ModUser = textBox5.Text;
            
           
            LoginResponse lr = await PostSizeAsync(size);
            if (lr != null)
            {
                MessageBox.Show("Your Data inserted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Data not inserted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task<LoginResponse> PostSizeAsync(ColorsModel request)
        {
            try
            {
               
                string jsonRequest = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                HttpClient _httpClient = new HttpClient();
               
                HttpResponseMessage response = await _httpClient.PostAsync("http://localhost:82/api/Size_Color", content);

               
                response.EnsureSuccessStatusCode();

               
                string jsonResponse = await response.Content.ReadAsStringAsync();
                LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(jsonResponse);

                return loginResponse;
            }
            catch (Exception ex)
            {
                
                return new LoginResponse { Success = false, Message = $"Error: {ex.Message}" };
            }
        }
    }
}
