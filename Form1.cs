﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                int kq = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                textBoxkq.Text = Convert.ToString(kq);
            }
        }
    }
}
