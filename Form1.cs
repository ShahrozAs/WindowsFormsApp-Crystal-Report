using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace WindowsFormsApp_Advance_Teaching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             windowShowForm windowShowForm = new windowShowForm();
             LoginSignup report = new LoginSignup();
            TextObject first =(TextObject) report.ReportDefinition.Sections["Section3"].ReportObjects["FirstnameText"];
            first.Text = FirstNameTextBox.Text;
            
            TextObject last =(TextObject) report.ReportDefinition.Sections["Section3"].ReportObjects["LastnameText"];
            last.Text = LastNameTextBox.Text;    
            
            TextObject username =(TextObject) report.ReportDefinition.Sections["Section3"].ReportObjects["UsernameText"];
            username.Text = UserNameTextBox.Text;     
            
            TextObject password =(TextObject) report.ReportDefinition.Sections["Section3"].ReportObjects["PasswordText"];
            password.Text =PasswordTextBox.Text;
            windowShowForm.crystalReportViewer1.ReportSource= report;
            windowShowForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
