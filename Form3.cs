﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MonthCalendar1.Visible = false;
            MonthCalendar2.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
