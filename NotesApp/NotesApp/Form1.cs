using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        int second = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dayTime = DateTime.Now;
            timeDay.Text = dayTime.ToShortTimeString();
            dayWeek.Text = dayTime.ToShortDateString();

            timer1.Enabled = true;
            if (second < 5)
            {
                metroTabPage5.BackgroundImage = Properties.Resources.Back1;
                second++;
                guna2ProgressBar1.Value = 1;
            }
            else if (second >= 5 && second < 10)
            {
                metroTabPage5.BackgroundImage = Properties.Resources.Back2;
                second++;
                guna2ProgressBar1.Value = 2;
            }
            else if (second >= 10 && second < 15)
            {
                metroTabPage5.BackgroundImage = Properties.Resources.Back3;
                second++;
                guna2ProgressBar1.Value = 3;
            }
            else second = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
        }
    }
}
