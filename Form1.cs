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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MonthCalendar1.Visible = false;
            MonthCalendar2.Visible = false;
            label9.Visible = false;

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

            MonthCalendar1.Visible = true;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MonthCalendar2.Visible = true;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label7.Text = MonthCalendar1.SelectionStart.ToString();
            MonthCalendar1.Visible = false;
        }

        private void MonthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            label8.Text = MonthCalendar2.SelectionStart.ToString();
            MonthCalendar2.Visible = false;
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 x = new Form2();
            this.Hide();
            x.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (RichTextBox1.Text == null)
            {
                label9.Visible = true;
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            this.Hide();
            x.Show();
        }
    }
}
   