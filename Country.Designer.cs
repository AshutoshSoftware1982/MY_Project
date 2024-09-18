namespace WindowsFormsApp1
{
    partial class Country
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.text_TimeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Abbreviation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.com_Active = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_Country = new System.Windows.Forms.CheckBox();
            this.btn_AddData = new System.Windows.Forms.Button();
            this.btn_NewData = new System.Windows.Forms.Button();
            this.com_CountryID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(77, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 427);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.text_TimeName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_Abbreviation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.com_Active);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.check_Country);
            this.groupBox1.Controls.Add(this.btn_AddData);
            this.groupBox1.Controls.Add(this.btn_NewData);
            this.groupBox1.Controls.Add(this.com_CountryID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(79, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country Details Entry";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // text_TimeName
            // 
            this.text_TimeName.Location = new System.Drawing.Point(172, 215);
            this.text_TimeName.Name = "text_TimeName";
            this.text_TimeName.Size = new System.Drawing.Size(192, 26);
            this.text_TimeName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time Name";
            // 
            // text_Abbreviation
            // 
            this.text_Abbreviation.Location = new System.Drawing.Point(172, 173);
            this.text_Abbreviation.Name = "text_Abbreviation";
            this.text_Abbreviation.Size = new System.Drawing.Size(192, 26);
            this.text_Abbreviation.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Abbreviation";
            // 
            // com_Active
            // 
            this.com_Active.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Active.FormattingEnabled = true;
            this.com_Active.Location = new System.Drawing.Point(172, 129);
            this.com_Active.Name = "com_Active";
            this.com_Active.Size = new System.Drawing.Size(192, 26);
            this.com_Active.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "IsActive";
            // 
            // check_Country
            // 
            this.check_Country.AutoSize = true;
            this.check_Country.Location = new System.Drawing.Point(371, 46);
            this.check_Country.Name = "check_Country";
            this.check_Country.Size = new System.Drawing.Size(15, 14);
            this.check_Country.TabIndex = 7;
            this.check_Country.UseVisualStyleBackColor = true;
            this.check_Country.CheckedChanged += new System.EventHandler(this.check_Country_CheckedChanged);
            // 
            // btn_AddData
            // 
            this.btn_AddData.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_AddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddData.ForeColor = System.Drawing.Color.Black;
            this.btn_AddData.Location = new System.Drawing.Point(237, 264);
            this.btn_AddData.Name = "btn_AddData";
            this.btn_AddData.Size = new System.Drawing.Size(127, 31);
            this.btn_AddData.TabIndex = 5;
            this.btn_AddData.Text = "ADD DATA";
            this.btn_AddData.UseVisualStyleBackColor = true;
            this.btn_AddData.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // btn_NewData
            // 
            this.btn_NewData.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_NewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewData.ForeColor = System.Drawing.Color.Black;
            this.btn_NewData.Location = new System.Drawing.Point(104, 264);
            this.btn_NewData.Name = "btn_NewData";
            this.btn_NewData.Size = new System.Drawing.Size(127, 31);
            this.btn_NewData.TabIndex = 4;
            this.btn_NewData.Text = "NEW DATA";
            this.btn_NewData.UseVisualStyleBackColor = true;
            this.btn_NewData.Click += new System.EventHandler(this.btn_NewData_Click);
            // 
            // com_CountryID
            // 
            this.com_CountryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_CountryID.FormattingEnabled = true;
            this.com_CountryID.Location = new System.Drawing.Point(172, 38);
            this.com_CountryID.Name = "com_CountryID";
            this.com_CountryID.Size = new System.Drawing.Size(192, 26);
            this.com_CountryID.TabIndex = 2;
            this.com_CountryID.SelectedIndexChanged += new System.EventHandler(this.com_CountryID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Code";
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country";
            this.Load += new System.EventHandler(this.Country_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_TimeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Abbreviation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_Country;
        private System.Windows.Forms.Button btn_AddData;
        private System.Windows.Forms.Button btn_NewData;
        private System.Windows.Forms.ComboBox com_CountryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}