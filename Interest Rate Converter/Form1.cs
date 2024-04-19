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
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_AerToGross)
            {

            }
            else
            {
                
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_AerToGross)
            {

            }
            else
            {

            }
        }
    }
}
