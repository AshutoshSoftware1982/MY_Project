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
namespace WindowsFormsApp1
{
    public partial class Country : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ashutosh;Initial Catalog=ERP_Project;Persist Security Info=True;User ID=sa;password=cellhut*321;");
        public Country()
        {
            InitializeComponent();
        }

        private void Country_Load(object sender, EventArgs e)
        {
            com_CountryID.Enabled = false;

            for (int i = 1; i <= 2; i++)
            {
                com_Active.Items.Add(i.ToString());
            }
            Country_Code();
            com_CountryID.Enabled = false;
        }

        private void btn_NewData_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            com_Active.Text = "";

            text_Abbreviation.Text = "";
            text_TimeName.Text = "";
        }

        private void btn_AddData_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Country values('" + comboBox1.Text + "','" + com_Active.Text + "','" + text_Abbreviation.Text + "','" + text_TimeName.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submmitted!!!");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Submitted!!!");
            }
        }

        private void check_Country_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Country.Checked == true)
            {
                com_CountryID.Enabled = true;
            }
            else
            {
                com_CountryID.Enabled = false;
            }
        }
       

        public async void Country_Code()
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select CountryCode from Country", conn);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //com_CountryID.DisplayMember = "CountryCode";
            //com_CountryID.DataSource = dt;
            //conn.Close();
            string apiUrl = "http://localhost:82/api/Country/GetCountryCode";

            try
            {
                CommanAPI_call ca = new CommanAPI_call ();
                List<string> data = await ca.FetchCodeFromApiAsync(apiUrl);
                com_CountryID.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private async void com_CountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Country_Name from Country where CountryCode='" + com_CountryID.Text + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.DisplayMember = "Country_Name";
            comboBox1.DataSource = dt;
            conn.Close();
            //string apiUrl = "http://localhost:82/api/Country/GetAllCountry";

            //try
            //{
            //    CommanAPI_call ca = new CommanAPI_call();
            //    List<string> data = await ca.FetchNameFromApiAsync(apiUrl);
            //    comboBox1.DataSource = data;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error fetching data: " + ex.Message);
            //}
        }
    }
}
