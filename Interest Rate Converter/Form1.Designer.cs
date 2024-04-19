
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
            this.rdobtn_AERToGross = new System.Windows.Forms.RadioButton();
            this.rdobtn_GrossToAER = new System.Windows.Forms.RadioButton();
            this.lbl_ResultingAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_InterestRate = new System.Windows.Forms.TextBox();
            this.lbl_interest_rate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbobx_interest_frequency = new System.Windows.Forms.ComboBox();
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_calc, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 513);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1086, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(889, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(194, 68);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc.Location = new System.Drawing.Point(446, 3);
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
            this.panel1.Size = new System.Drawing.Size(1086, 504);
            this.panel1.TabIndex = 2;
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
            this.lbl_ResultingAnswer.Location = new System.Drawing.Point(14, 299);
            this.lbl_ResultingAnswer.Name = "lbl_ResultingAnswer";
            this.lbl_ResultingAnswer.Size = new System.Drawing.Size(21, 20);
            this.lbl_ResultingAnswer.TabIndex = 11;
            this.lbl_ResultingAnswer.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "%";
            // 
            // txtbx_InterestRate
            // 
            this.txtbx_InterestRate.Location = new System.Drawing.Point(170, 163);
            this.txtbx_InterestRate.Name = "txtbx_InterestRate";
            this.txtbx_InterestRate.Size = new System.Drawing.Size(112, 26);
            this.txtbx_InterestRate.TabIndex = 9;
            // 
            // lbl_interest_rate
            // 
            this.lbl_interest_rate.AutoSize = true;
            this.lbl_interest_rate.Location = new System.Drawing.Point(14, 166);
            this.lbl_interest_rate.Name = "lbl_interest_rate";
            this.lbl_interest_rate.Size = new System.Drawing.Size(150, 20);
            this.lbl_interest_rate.TabIndex = 8;
            this.lbl_interest_rate.Text = "Gross Interest Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interest Frequency";
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
            this.cmbobx_interest_frequency.Location = new System.Drawing.Point(170, 212);
            this.cmbobx_interest_frequency.Name = "cmbobx_interest_frequency";
            this.cmbobx_interest_frequency.Size = new System.Drawing.Size(174, 28);
            this.cmbobx_interest_frequency.TabIndex = 6;
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(390, 26);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(678, 457);
            this.rchtxtbx_output.TabIndex = 14;
            this.rchtxtbx_output.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_AERToGross);
            this.groupBox1.Controls.Add(this.rdobtn_GrossToAER);
            this.groupBox1.Controls.Add(this.lbl_ResultingAnswer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_InterestRate);
            this.groupBox1.Controls.Add(this.lbl_interest_rate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbobx_interest_frequency);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 457);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_InterestRate;
        private System.Windows.Forms.Label lbl_interest_rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbobx_interest_frequency;
        private System.Windows.Forms.RadioButton rdobtn_AERToGross;
        private System.Windows.Forms.RadioButton rdobtn_GrossToAER;
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

