﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator___project_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";
            if (numberGrade > 100)
            {
                letterGrade = "error";
            }
            else if (numberGrade >= 88 && numberGrade <=100)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
         
            txtLetterGrade.Text = letterGrade;
        }

        private void txtLetterGrade_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
