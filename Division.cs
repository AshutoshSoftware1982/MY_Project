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
using System.Security.Cryptography;
namespace WindowsFormsApp1
{
    public partial class Division : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ashutosh;Initial Catalog=ERP_Project;Persist Security Info=True;User ID=sa;password=cellhut*321;");
        public Division()
        {
            InitializeComponent();
            
            Load_Data();
            LoadCountry();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
       
        public async void Division_code()
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select DivisionCode from Division", conn);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //comDivi_Code.DisplayMember = "DivisionCode";
            //comDivi_Code.DataSource = dt;
            //conn.Close();
            string apiUrl = "http://localhost:82/api/Division/GetDivisonCode";

            try
            {
                CommanAPI_call commanAPI_Call = new CommanAPI_call();
                List<string> data = await commanAPI_Call.FetchDivisionFromApiAsync(apiUrl);
                comDivi_Code.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        public async void Client_Code()
        {
           
            string apiUrl = "http://localhost:82/api/Customer/GetClientCode";

            try
            {
                CommanAPI_call commanAPI_Call2 = new CommanAPI_call();
                List<string> data = await commanAPI_Call2.FetchClientFromApiAsync(apiUrl);
                comCli_Code.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
       
        public void Load_Data()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Division", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Division");
                dataGridView1.DataSource = ds.Tables["Division"].DefaultView;
                conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Found!!!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       private void comDivi_Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn.Open();
            SqlCommand cmd = new SqlCommand("select * from division where DivisionCode='" + comDivi_Code.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comCli_Code.Text = dt.Rows[i]["CustomerId"].ToString();
                    txtDivi_Name.Text = dt.Rows[i]["DivisionName"].ToString();
                    com_Country.Text = dt.Rows[i]["Country"].ToString();
                    com_State.Text = dt.Rows[i]["State"].ToString();
                    txt_City.Text = dt.Rows[i]["City"].ToString();

                }
            }
            conn.Close();
        }
        public async void Load_State()
        {

            string apiUrl = "http://localhost:82/api/State/GetStateName?Country_Name='" + com_Country.Text + "'";

            try
            {
                CommanAPI_call commanAPI_Call = new CommanAPI_call();
                List<string> data = await commanAPI_Call.FetchStateFromApiAsync(apiUrl);
                com_State.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comDivi_Code.Enabled = true;
            }
            else
            {
                comDivi_Code.Enabled = false;
            }
        }

        private void Division_Load(object sender, EventArgs e)
        {
            Division_code();
            Client_Code();
            comDivi_Code.Enabled = false;
            btn_Update.Enabled = false;

            comCli_Code.Text = "";
            txtDivi_Name.Text = "";
            com_Country.Text = "";
            com_State.Text = "";
            txt_City.Text = "";
        }

        private  void com_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select State_Name from tbl_State where Country_Name='" + com_Country.Text + "' ", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            com_State.DisplayMember = "State_Name";
            com_State.DataSource = dt;
            conn.Close();

        }
       
        public async void LoadCountry()
        {
            string apiUrl = "http://localhost:82/api/Country/GetAllCountry"; 

            try
            {
                CommanAPI_call  commanAPI_Call = new CommanAPI_call();
                List<string> data = await commanAPI_Call.FetchDataFromApiAsync(apiUrl);
                com_Country.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
        

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand sqlCommand = new SqlCommand("sp_Division", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", comCli_Code.Text);
                sqlCommand.Parameters.AddWithValue("@DivisionName", txtDivi_Name.Text);
                sqlCommand.Parameters.AddWithValue("@Country", com_Country.Text);
                sqlCommand.Parameters.AddWithValue("@State", com_State.Text);
                sqlCommand.Parameters.AddWithValue("@City", txt_City.Text);
                sqlCommand.Parameters.AddWithValue("@Fin_Entity", txt_Entity.Text);
                sqlCommand.Parameters.AddWithValue("@Div_Group", txt_Group.Text);
                sqlCommand.Parameters.AddWithValue("@Division_Group", txt_DivisionName.Text);
                sqlCommand.Parameters.AddWithValue("@Address1", txt_Address1.Text);
                sqlCommand.Parameters.AddWithValue("@Address2", txt_Address2.Text);
                sqlCommand.Parameters.AddWithValue("@Zip", txt_Zip.Text);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", txt_PhoneNumber.Text);
                sqlCommand.Parameters.AddWithValue("@Fax", txt_Fax.Text);
                sqlCommand.Parameters.AddWithValue("@ManufacturerID", txt_ManuID.Text);
                sqlCommand.Parameters.AddWithValue("@G_Code", txt_GCode.Text);
                sqlCommand.Parameters.AddWithValue("@Days_To_Start", txt_DaysStart.Text);
                sqlCommand.Parameters.AddWithValue("@Days_To_Cancel", txt_Cancel.Text);
                sqlCommand.Parameters.AddWithValue("@Duns_No", txt_DunsNo.Text);
                sqlCommand.Parameters.AddWithValue("@Base_Currency", txt_BaseCurrency.Text);
                sqlCommand.Parameters.AddWithValue("@RN", txt_RN.Text);
                sqlCommand.Parameters.AddWithValue("@Email_Sender_Account", txt_SenderAccount.Text);
                sqlCommand.Parameters.AddWithValue("@StatementType", "Insert");
                conn.Open();
                int k = sqlCommand.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("New Data Submitted!!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                conn.Close();
                Load_Data();
            }
            catch(Exception)
            {
                MessageBox.Show("New Data Not Submitted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //update Data
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Division set CustomerID='" + comCli_Code.Text + "',DivisionName='" + txtDivi_Name.Text + "',Country='" + com_Country.Text + "',State='" + com_State.Text + "',City='" + txt_City.Text + "' where DivsionCode='" + comDivi_Code.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Update!!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Update!!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Search Data
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Division where DivisionCode='" + comDivi_Code.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Division");
                dataGridView1.DataSource = ds.Tables["Division"].DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_NewData_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_NewData_Click(object sender, EventArgs e)
        {
            comCli_Code.Text = "";
            txtDivi_Name.Text = "";
            com_Country.Text = "";
            com_State.Text = "";
            txt_City.Text = "";
        }
    }
}
