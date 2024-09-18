﻿using Newtonsoft.Json;
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
    public partial class Calendar_Data : Form
    {
        public Calendar_Data()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:82/api/Calendar_Data/GetCalendar");
                var consumeapi = hc.GetAsync("GetCalendar");
                consumeapi.Wait();
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    IList<Calendar_DataModel> MyDeserialisedObject =
                    JsonConvert.DeserializeObject<List<Calendar_DataModel>>(readdata.Content.ReadAsStringAsync().Result.ToString()).Cast<Calendar_DataModel>().ToList();
                    dataGridView1.DataSource = MyDeserialisedObject;
                    //label1.Visible = false;

                    //dataGridView1.EnableHeadersVisualStyles = false;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment.Equals(DataGridViewContentAlignment.MiddleLeft);



                    //dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                    //dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                    //dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                    //dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;


                }
            }
            catch (Exception)
            {

                //label1.Text = "Please check API";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Style_Calender fr = (Style_Calender)Application.OpenForms["Style_Calender"];
            int row = e.RowIndex;
            fr.txt_Calendar.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.Hide();
        }
    }
}