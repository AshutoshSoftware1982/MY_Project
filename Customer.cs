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
using Newtonsoft.Json;
using System.Net.Http;
using WindowsFormsApp1.Model;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ashutosh;Initial Catalog=ERP_Project;Persist Security Info=True;User ID=sa;password=cellhut*321;");
        public Customer()
        {
            InitializeComponent();
            GetCustomerID();
            Load_Country();
            Load_State();
            Gender_Data();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

            button2.Enabled = false;
            LoadData();
            Reset_Data();
        }
        public async void Load_Country()
        {

           string apiUrl = "http://localhost:82/api/Country/GetAllCountry";

            try
            {
                CommanAPI_call ca = new CommanAPI_call ();
                List<string> data = await ca.FetchDataFromApiAsync(apiUrl);
                comboBox3.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
       
        public async void Load_State()
        {
            string apiUrl = "http://localhost:82/api/State/GetStateName?Country_Name='" + comboBox3.Text + "'";

            try
            {
                CommanAPI_call ca = new CommanAPI_call();
                List<string> data = await ca.FetchStateFromApiAsync(apiUrl);
                comboBox4.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

        }
        public async void GetCustomerID()
        {
           
            string apiUrl = "http://localhost:82/api/Customer/GetAllCustomer";

            try
            {
                CommanAPI_call ca = new CommanAPI_call();
                List<string> data = await ca.FetchCustomerIDFromApiAsync(apiUrl);
                comboBox1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/Customer/GetAllCustomer");
                var consumeapi = hc.GetAsync("GetAllCustomer");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<CustomerModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<CustomerModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<CustomerModel>().ToList();
                    dataGridView1.DataSource = MyDeserialisedObject;
                    label7.Visible = false;

                    

                }
            }
            catch (Exception)
            {

                label7.Text = "Please check API";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                button2.Enabled = true;
                button2.Enabled = true;
            }
            else
            { comboBox1.Enabled = false; }
            button2.Enabled = false;
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            LoadData();
        }

        private  void button5_Click(object sender, EventArgs e)
        {
            //Search Data
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer where CustomerId='" + comboBox1.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Customer");
                dataGridView1.DataSource = ds.Tables["Customer"].DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            button2.Enabled = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update Data
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Customer set CustomerName='" + textBox1.Text + "',CustomerAddress='" + textBox2.Text + "',EmailID='" + textBox3.Text + "',Mobile_Number='" + textBox4.Text + "',Gender='" + comboBox2.Text + "',CustomerAddress2='" + textBox5.Text + "',CustomerAddress3='" + textBox6.Text + "',Country='" + comboBox3.Text + "',State='" + comboBox4.Text + "',City='" + textBox7.Text + "' where CustomerId='" + comboBox1.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Changed!!!");
                Reset_Data();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "')",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submmitted!!!");
                Reset_Data();
                conn.Close();
                LoadData();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Submitted!!!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where CustomerID='" + comboBox1.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    textBox1.Text = dt.Rows[i]["CustomerName"].ToString();
                    textBox2.Text = dt.Rows[i]["CustomerAddress"].ToString();
                    textBox3.Text = dt.Rows[i]["EmailID"].ToString();
                    textBox4.Text = dt.Rows[i]["Mobile_Number"].ToString();
                    comboBox2.Text = dt.Rows[i]["Gender"].ToString();
                    textBox5.Text = dt.Rows[i]["CustomerAddress2"].ToString();
                    textBox6.Text = dt.Rows[i]["CustomerAddress3"].ToString();
                    comboBox3.Text = dt.Rows[i]["Country"].ToString();
                    comboBox4.Text = dt.Rows[i]["State"].ToString();
                    textBox7.Text = dt.Rows[i]["City"].ToString();
                }
            }
            conn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select State_Name from tbl_State where  Country_Name='" + comboBox3.Text + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox4.DisplayMember = "State_Name";
            comboBox4.DataSource = dt;
            conn.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Reset_Data();
        }

        public void Validation_PhoneNumber()
        {
            Regex phonenumber = new Regex("\\d{4}-\\d{3}-\\d{4}");
            if (phonenumber.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Valid phone number!");
            }
            else
            {
                MessageBox.Show("Not Valid phone number!");
            }
        }
        public void Reset_Data()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox7.Text = "";
        }

        public void Gender_Data()
        {
            string[] gender = { "Male", "Female" };
            for (int i = 0; i < gender.Length; i++)
            {
                comboBox2.Items.Add(gender[i]);
            }
        }
    }
}
