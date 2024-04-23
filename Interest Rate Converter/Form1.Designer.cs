
namespace Interest_Rate_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpick_invetment_start = new System.Windows.Forms.DateTimePicker();
            this.lbl_investment_start = new System.Windows.Forms.Label();
            this.rdobtn_lifetime_AER = new System.Windows.Forms.RadioButton();
            this.rdobtn_AERToGross = new System.Windows.Forms.RadioButton();
            this.rdobtn_GrossToAER = new System.Windows.Forms.RadioButton();
            this.lbl_ResultingAnswer = new System.Windows.Forms.Label();
            this.lbl_percent_symbol = new System.Windows.Forms.Label();
            this.txtbx_InterestRateOrInitialValue = new System.Windows.Forms.TextBox();
            this.lbl_interest_rateOrInitialValue = new System.Windows.Forms.Label();
            this.lbl_InterestFrequencyOrCurrentValue = new System.Windows.Forms.Label();
            this.cmbobx_interest_frequency = new System.Windows.Forms.ComboBox();
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.txtbx_CurrentValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1111, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_calc, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 513);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1105, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(907, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(195, 68);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc.Location = new System.Drawing.Point(455, 3);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(194, 68);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(3, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(194, 68);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.rchtxtbx_output);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 504);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_CurrentValue);
            this.groupBox1.Controls.Add(this.dtpick_invetment_start);
            this.groupBox1.Controls.Add(this.lbl_investment_start);
            this.groupBox1.Controls.Add(this.rdobtn_lifetime_AER);
            this.groupBox1.Controls.Add(this.rdobtn_AERToGross);
            this.groupBox1.Controls.Add(this.rdobtn_GrossToAER);
            this.groupBox1.Controls.Add(this.lbl_ResultingAnswer);
            this.groupBox1.Controls.Add(this.lbl_percent_symbol);
            this.groupBox1.Controls.Add(this.txtbx_InterestRateOrInitialValue);
            this.groupBox1.Controls.Add(this.lbl_interest_rateOrInitialValue);
            this.groupBox1.Controls.Add(this.lbl_InterestFrequencyOrCurrentValue);
            this.groupBox1.Controls.Add(this.cmbobx_interest_frequency);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 474);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dtpick_invetment_start
            // 
            this.dtpick_invetment_start.Location = new System.Drawing.Point(172, 179);
            this.dtpick_invetment_start.Name = "dtpick_invetment_start";
            this.dtpick_invetment_start.Size = new System.Drawing.Size(208, 26);
            this.dtpick_invetment_start.TabIndex = 16;
            // 
            // lbl_investment_start
            // 
            this.lbl_investment_start.AutoSize = true;
            this.lbl_investment_start.Location = new System.Drawing.Point(16, 184);
            this.lbl_investment_start.Name = "lbl_investment_start";
            this.lbl_investment_start.Size = new System.Drawing.Size(127, 20);
            this.lbl_investment_start.TabIndex = 15;
            this.lbl_investment_start.Text = "Investment Start";
            // 
            // rdobtn_lifetime_AER
            // 
            this.rdobtn_lifetime_AER.AutoSize = true;
            this.rdobtn_lifetime_AER.Location = new System.Drawing.Point(67, 98);
            this.rdobtn_lifetime_AER.Name = "rdobtn_lifetime_AER";
            this.rdobtn_lifetime_AER.Size = new System.Drawing.Size(229, 24);
            this.rdobtn_lifetime_AER.TabIndex = 14;
            this.rdobtn_lifetime_AER.Text = "Lifetime AER of Investment";
            this.rdobtn_lifetime_AER.UseVisualStyleBackColor = true;
            this.rdobtn_lifetime_AER.CheckedChanged += new System.EventHandler(this.rdobtn_GrossToAER_CheckedChanged);
            // 
            // rdobtn_AERToGross
            // 
            this.rdobtn_AERToGross.AutoSize = true;
            this.rdobtn_AERToGross.Location = new System.Drawing.Point(196, 44);
            this.rdobtn_AERToGross.Name = "rdobtn_AERToGross";
            this.rdobtn_AERToGross.Size = new System.Drawing.Size(133, 24);
            this.rdobtn_AERToGross.TabIndex = 13;
            this.rdobtn_AERToGross.Text = "AER to Gross";
            this.rdobtn_AERToGross.UseVisualStyleBackColor = true;
            this.rdobtn_AERToGross.CheckedChanged += new System.EventHandler(this.rdobtn_GrossToAER_CheckedChanged);
            // 
            // rdobtn_GrossToAER
            // 
            this.rdobtn_GrossToAER.AutoSize = true;
            this.rdobtn_GrossToAER.Checked = true;
            this.rdobtn_GrossToAER.Location = new System.Drawing.Point(20, 44);
            this.rdobtn_GrossToAER.Name = "rdobtn_GrossToAER";
            this.rdobtn_GrossToAER.Size = new System.Drawing.Size(137, 24);
            this.rdobtn_GrossToAER.TabIndex = 12;
            this.rdobtn_GrossToAER.TabStop = true;
            this.rdobtn_GrossToAER.Text = "Gross To AER";
            this.rdobtn_GrossToAER.UseVisualStyleBackColor = true;
            this.rdobtn_GrossToAER.CheckedChanged += new System.EventHandler(this.rdobtn_GrossToAER_CheckedChanged);
            // 
            // lbl_ResultingAnswer
            // 
            this.lbl_ResultingAnswer.AutoSize = true;
            this.lbl_ResultingAnswer.Location = new System.Drawing.Point(16, 359);
            this.lbl_ResultingAnswer.Name = "lbl_ResultingAnswer";
            this.lbl_ResultingAnswer.Size = new System.Drawing.Size(21, 20);
            this.lbl_ResultingAnswer.TabIndex = 11;
            this.lbl_ResultingAnswer.Text = "...";
            // 
            // lbl_percent_symbol
            // 
            this.lbl_percent_symbol.AutoSize = true;
            this.lbl_percent_symbol.Location = new System.Drawing.Point(290, 226);
            this.lbl_percent_symbol.Name = "lbl_percent_symbol";
            this.lbl_percent_symbol.Size = new System.Drawing.Size(23, 20);
            this.lbl_percent_symbol.TabIndex = 10;
            this.lbl_percent_symbol.Text = "%";
            // 
            // txtbx_InterestRateOrInitialValue
            // 
            this.txtbx_InterestRateOrInitialValue.Location = new System.Drawing.Point(172, 223);
            this.txtbx_InterestRateOrInitialValue.Name = "txtbx_InterestRateOrInitialValue";
            this.txtbx_InterestRateOrInitialValue.Size = new System.Drawing.Size(112, 26);
            this.txtbx_InterestRateOrInitialValue.TabIndex = 9;
            // 
            // lbl_interest_rateOrInitialValue
            // 
            this.lbl_interest_rateOrInitialValue.AutoSize = true;
            this.lbl_interest_rateOrInitialValue.Location = new System.Drawing.Point(16, 226);
            this.lbl_interest_rateOrInitialValue.Name = "lbl_interest_rateOrInitialValue";
            this.lbl_interest_rateOrInitialValue.Size = new System.Drawing.Size(150, 20);
            this.lbl_interest_rateOrInitialValue.TabIndex = 8;
            this.lbl_interest_rateOrInitialValue.Text = "Gross Interest Rate";
            // 
            // lbl_InterestFrequencyOrCurrentValue
            // 
            this.lbl_InterestFrequencyOrCurrentValue.AutoSize = true;
            this.lbl_InterestFrequencyOrCurrentValue.Location = new System.Drawing.Point(16, 275);
            this.lbl_InterestFrequencyOrCurrentValue.Name = "lbl_InterestFrequencyOrCurrentValue";
            this.lbl_InterestFrequencyOrCurrentValue.Size = new System.Drawing.Size(143, 20);
            this.lbl_InterestFrequencyOrCurrentValue.TabIndex = 7;
            this.lbl_InterestFrequencyOrCurrentValue.Text = "Interest Frequency";
            // 
            // cmbobx_interest_frequency
            // 
            this.cmbobx_interest_frequency.FormattingEnabled = true;
            this.cmbobx_interest_frequency.Items.AddRange(new object[] {
            "Annual",
            "Bi-Annual",
            "Quarterly",
            "Bi-Monthly",
            "Monthly",
            "Bi-Weekly",
            "Weekly",
            "Daily"});
            this.cmbobx_interest_frequency.Location = new System.Drawing.Point(172, 272);
            this.cmbobx_interest_frequency.Name = "cmbobx_interest_frequency";
            this.cmbobx_interest_frequency.Size = new System.Drawing.Size(174, 28);
            this.cmbobx_interest_frequency.TabIndex = 6;
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(404, 19);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.ReadOnly = true;
            this.rchtxtbx_output.Size = new System.Drawing.Size(692, 464);
            this.rchtxtbx_output.TabIndex = 14;
            this.rchtxtbx_output.Text = "";
            // 
            // txtbx_CurrentValue
            // 
            this.txtbx_CurrentValue.Location = new System.Drawing.Point(172, 272);
            this.txtbx_CurrentValue.Name = "txtbx_CurrentValue";
            this.txtbx_CurrentValue.Size = new System.Drawing.Size(112, 26);
            this.txtbx_CurrentValue.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Rate Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ResultingAnswer;
        private System.Windows.Forms.Label lbl_percent_symbol;
        private System.Windows.Forms.TextBox txtbx_InterestRateOrInitialValue;
        private System.Windows.Forms.Label lbl_interest_rateOrInitialValue;
        private System.Windows.Forms.Label lbl_InterestFrequencyOrCurrentValue;
        private System.Windows.Forms.ComboBox cmbobx_interest_frequency;
        private System.Windows.Forms.RadioButton rdobtn_AERToGross;
        private System.Windows.Forms.RadioButton rdobtn_GrossToAER;
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtn_lifetime_AER;
        private System.Windows.Forms.DateTimePicker dtpick_invetment_start;
        private System.Windows.Forms.Label lbl_investment_start;
        private System.Windows.Forms.TextBox txtbx_CurrentValue;
    }
}

