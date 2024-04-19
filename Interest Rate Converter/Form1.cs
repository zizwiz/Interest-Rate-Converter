using System;
using System.Reflection;
using System.Windows.Forms;

namespace Interest_Rate_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" +
                    Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
            cmbobx_interest_frequency.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_AerToGross)
            {
                txtbx_GrossInterest.Text = "";
                lbl_AerToGross.Text = "";
                cmbobx_interest_frequency.SelectedIndex = 0;
            }
            else
            {
                
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_AerToGross)
            {
                ///AER = (1 + r/n)^n – 1
                /// r is the gross interest in decimal 5% = 0.05 
                ///n is the number of compounding periods in any 12 - month period.
                /// daily is for next twelve months beware of leap year as this adds extra day.
                
                double InterestFrequency;

                switch (cmbobx_interest_frequency.Text)
                {
                    case "Annual": InterestFrequency = 12; break;
                    case "Bi-Annual": InterestFrequency = 6; break;
                    case "Quarterly": InterestFrequency = 4; break;
                    case "Bi-Monthly": InterestFrequency = 24; break;
                    case "Monthly": InterestFrequency = 12; break;
                    case "Bi-Weekly": InterestFrequency = 104; break;
                    case "Weekly": InterestFrequency = 52; break;
                    case "Daily": InterestFrequency = NumberOfDaysInNextYear(); break;
                    default: InterestFrequency = 0; break;
                }
               
                lbl_AerToGross.Text = "AER interest for 1 year from today = " + Math.Round(((Math.Pow((1 + ((double.Parse(txtbx_GrossInterest.Text) / 100) / InterestFrequency)), InterestFrequency)-1)*100),2);
            }
            else
            {

            }
        }

        private int NumberOfDaysInNextYear()
        {
            var futureDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            var currentDate = DateTime.Today;

            TimeSpan daysInNextYear = futureDate - currentDate;
            return daysInNextYear.Days;
        }
    }
}
