using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString();
            monthCalendar1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = monthCalendar2.SelectionStart.ToString();
            monthCalendar2.Visible = false;
        }
    }
}
