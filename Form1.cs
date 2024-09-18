using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection.Emit;
using WindowsFormsApp1.Model;
using Newtonsoft.Json.Linq;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        List<LoginModel> MyDeserialisedObject;
        SqlConnection conn = new SqlConnection("Data Source=ashutosh;Initial Catalog=ERP_Project;Persist Security Info=True;User ID=sa;password=cellhut*321;");
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        public string PrepareSqlStr(string sqlStr)
        {
            sqlStr = sqlStr.Replace("'", "");
            return sqlStr;
        }
        //Get Type API use in Login Page
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:82/api/Login/GetLogin?UserName="+txtusername.Text+"&UPassword="+txt_Password.Text+"";

            try
            {
                List<LoginModel> data = await FetchLoginFromApiAsync(apiUrl);
                
                if (data[0].Status==1)
                { 
                    MessageBox.Show("Welcome To ERP:" + txtusername.Text);
                    Dashboard mDIParent1 = new Dashboard();
                    SetValueForText1 = txtusername.Text;
                    SetValueForText2 = txt_Password.Text;
                    mDIParent1.Show();
                }
                else
                {
                    MessageBox.Show("Please check user name and password");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
        public async Task<List<LoginModel>> FetchLoginFromApiAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
               
                var de=JsonConvert.DeserializeObject<List<LoginModel>>(responseBody);
                return de;
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {


                txt_Password.UseSystemPasswordChar = false;


            }
            else
            {

                txt_Password.UseSystemPasswordChar = true;

            }
        }
    }
}
