using System;
using System.Reflection;
using System.Runtime.InteropServices;
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

            ResetData();
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void ResetData()
        {
            lbl_investment_start.Visible = false;
            dtpick_invetment_start.Visible = false;
            lbl_percent_symbol.Visible = true;
            cmbobx_interest_frequency.Visible = true;
            txtbx_CurrentValue.Visible = false;
            txtbx_InterestRateOrInitialValue.Text = "";
            lbl_ResultingAnswer.Text = "";
            cmbobx_interest_frequency.SelectedIndex = 0;
            rdobtn_GrossToAER.Checked = true;
            rchtxtbx_output.Text = "";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            ///Gross = n*((1+p)^(1/n)-1)
            ///AER = (1 + r/n)^n – 1
            /// 
            /// r is the gross interest in decimal 5% = 0.05
            /// p is AER in decimal 5% = 0.05
            /// n is the number of compounding periods in any 12 - month period.
            ///   daily is for next twelve months beware of leap year as this adds extra day.
            ///
            /// Test 5.1% AER = 4.89% Gross

            double InterestFrequency;
            double answer;

            switch (cmbobx_interest_frequency.Text)
            {
                case "Annually": InterestFrequency = 1; break;
                case "Bi-Annually": InterestFrequency = 2; break;
                case "Quarterly": InterestFrequency = 4; break;
                case "Bi-Monthly": InterestFrequency = 6; break;
                case "Monthly": InterestFrequency = 12; break;
                case "Bi-Weekly": InterestFrequency = 21; break;
                case "Weekly": InterestFrequency = 52; break;
                case "Daily": InterestFrequency = NumberOfDaysInNextYear(); break;
                default: InterestFrequency = 0; break;
            }

            if (rdobtn_GrossToAER.Checked)
            {
                answer = Math.Round(
                        ((Math.Pow(
                            (1 + ((double.Parse(txtbx_InterestRateOrInitialValue.Text) / 100) /
                                  InterestFrequency)), InterestFrequency) - 1) * 100), 2);

                rchtxtbx_output.AppendText("Gross of " + txtbx_InterestRateOrInitialValue.Text +
                                           "% when interest is compounded " + cmbobx_interest_frequency.Text.ToLower() +
                                           " for the next " + NumberOfDaysInNextYear() +
                                           " days is equivalent to AER of " + answer + "%\r");

                lbl_ResultingAnswer.Text = "AER interest is = " + answer + "%";
            }
            else if (rdobtn_AERToGross.Checked)
            {
                    answer = Math.Round((InterestFrequency * (Math.Pow(
                        (1 + (double.Parse(txtbx_InterestRateOrInitialValue.Text) / 100)),
                        (1 / InterestFrequency)) - 1)) * 100, 2);

                    rchtxtbx_output.AppendText("AER of " + txtbx_InterestRateOrInitialValue.Text +
                                               "% when interest will be compounded " + cmbobx_interest_frequency.Text.ToLower() +
                                               " for the next " + NumberOfDaysInNextYear() +
                                               " days is equivalent to Gross of " + answer + "%\r");
                
                lbl_ResultingAnswer.Text = "Gross interest is " + answer + "%";
            }
            else
            {
                //rdobtn_lifetime_AER is checked.

                double totalYears = Math.Floor(
                    (DateTime.Today - dtpick_invetment_start.Value).TotalDays
                    / 365.2425);


                var result =
                   (Math.Pow(double.Parse(txtbx_CurrentValue.Text) / double.Parse(txtbx_InterestRateOrInitialValue.Text), 1 / totalYears)
                    - 1) * 100;

                lbl_ResultingAnswer.Text = "Lifetime AER = " + Math.Round(result, 2) + "%";

            }
        }

        private int NumberOfDaysInNextYear()
        {
            // We use this to check how many days in the following year. If there is a 29 Feb then we count this
            // when we calculate over days. You get more interest as there is one more day.

            var futureDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            var currentDate = DateTime.Today;

            TimeSpan daysInNextYear = futureDate - currentDate;
            return daysInNextYear.Days;
        }

        private void rdobtn_GrossToAER_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn_AERToGross.Checked)
            {
                lbl_investment_start.Visible = false;
                dtpick_invetment_start.Visible = false;
                lbl_percent_symbol.Visible = true;
                cmbobx_interest_frequency.Visible = true;
                txtbx_CurrentValue.Visible = false;
                lbl_interest_rateOrInitialValue.Text = "AER Interest Rate";
                lbl_InterestFrequencyOrCurrentValue.Text = "Interest Frequency";
            }
            else if (rdobtn_GrossToAER.Checked)
            {
                lbl_investment_start.Visible = false;
                dtpick_invetment_start.Visible = false;
                lbl_percent_symbol.Visible = true;
                cmbobx_interest_frequency.Visible = true;
                txtbx_CurrentValue.Visible = false;
                lbl_interest_rateOrInitialValue.Text = "Gross Interest Rate";
                lbl_InterestFrequencyOrCurrentValue.Text = "Interest Frequency";
            }
            else
            {
                lbl_investment_start.Visible = true;
                dtpick_invetment_start.Visible = true;
                lbl_percent_symbol.Visible = false;
                cmbobx_interest_frequency.Visible = false;
                txtbx_CurrentValue.Visible = true;
                lbl_interest_rateOrInitialValue.Text = "Initial Investment";
                lbl_InterestFrequencyOrCurrentValue.Text = "Current Value";
            }
        }
    }
}
