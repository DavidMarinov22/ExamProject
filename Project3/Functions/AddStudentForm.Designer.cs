using System;
using System.Linq;

namespace Project3
{
    partial class AddStudentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFIrstName = new System.Windows.Forms.TextBox();
            this.txtSurename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.txtEGN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yearAndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // txtFIrstName
            // 
            this.txtFIrstName.Location = new System.Drawing.Point(108, 69);
            this.txtFIrstName.Name = "txtFIrstName";
            this.txtFIrstName.Size = new System.Drawing.Size(100, 23);
            this.txtFIrstName.TabIndex = 2;
            // 
            // txtSurename
            // 
            this.txtSurename.Location = new System.Drawing.Point(108, 107);
            this.txtSurename.Name = "txtSurename";
            this.txtSurename.Size = new System.Drawing.Size(100, 23);
            this.txtSurename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surename";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grade";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxGrade.Location = new System.Drawing.Point(108, 211);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(50, 23);
            this.comboBoxGrade.TabIndex = 10;
            // 
            // txtEGN
            // 
            this.txtEGN.Location = new System.Drawing.Point(108, 173);
            this.txtEGN.Name = "txtEGN";
            this.txtEGN.Size = new System.Drawing.Size(100, 23);
            this.txtEGN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "EGN/PIN";
            // 
            // txtClassNum
            // 
            this.txtClassNum.Location = new System.Drawing.Point(145, 247);
            this.txtClassNum.Name = "txtClassNum";
            this.txtClassNum.Size = new System.Drawing.Size(38, 23);
            this.txtClassNum.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number in class";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            " 1950/1951",
            " 1951/1952",
            " 1952/1953",
            " 1953/1954",
            " 1954/1955",
            " 1955/1956",
            " 1956/1957",
            " 1957/1958",
            " 1958/1959",
            " 1959/1960",
            " 1960/1961",
            " 1961/1962",
            " 1962/1963",
            " 1963/1964",
            " 1964/1965",
            " 1965/1966",
            " 1966/1967",
            " 1967/1968",
            " 1968/1969",
            " 1969/1970",
            " 1970/1971",
            " 1971/1972",
            " 1972/1973",
            " 1973/1974",
            " 1974/1975",
            " 1975/1976",
            " 1976/1977",
            " 1977/1978",
            " 1978/1979",
            " 1979/1980",
            " 1980/1981",
            " 1981/1982",
            " 1982/1983",
            " 1983/1984",
            " 1984/1985",
            " 1985/1986",
            " 1986/1987",
            " 1987/1988",
            " 1988/1989",
            " 1989/1990",
            " 1990/1991",
            " 1991/1992",
            " 1992/1993",
            " 1993/1994",
            " 1994/1995",
            " 1995/1996",
            " 1996/1997",
            " 1997/1998",
            " 1998/1999",
            " 1999/2000",
            " 2000/2001",
            " 2001/2002",
            " 2002/2003",
            " 2003/2004",
            " 2004/2005",
            " 2005/2006",
            " 2006/2007",
            " 2007/2008",
            " 2008/2009",
            " 2009/20010",
            " 2010/2011",
            " 2011/2012",
            " 2012/2013",
            " 2013/2014",
            " 2014/2015",
            " 2015/2016",
            " 2016/2017",
            " 2017/2018",
            " 2018/2019",
            " 2019/2020",
            " 2020/2021",
            " 2021/2022",
            " 2022/2023",
            " 2023/2024",
            " 2024/2025",
            " 2025/2026",
            " 2026/2027",
            " 2027/2028",
            " 2028/2029",
            " 2029/2030",
            " 2030/2031"});
            this.comboBoxYear.Location = new System.Drawing.Point(334, 77);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(90, 23);
            this.comboBoxYear.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(231, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "School year";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Graduate",
            "Exchanged"});
            this.comboBoxStatus.Location = new System.Drawing.Point(108, 284);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(85, 23);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status";
            // 
            // yearAndDate
            // 
            this.yearAndDate.Location = new System.Drawing.Point(334, 124);
            this.yearAndDate.Name = "yearAndDate";
            this.yearAndDate.Size = new System.Drawing.Size(200, 23);
            this.yearAndDate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(231, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Year and date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(145, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Add new student";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(392, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back to main";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(556, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yearAndDate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClassNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEGN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFIrstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStudentForm";
            this.Text = "Add student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFIrstName;
        private System.Windows.Forms.TextBox txtSurename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.TextBox txtEGN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker yearAndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}