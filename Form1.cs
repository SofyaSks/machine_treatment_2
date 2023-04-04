using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machine_treatment_2
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer(); 
        public Form1()
        {
            InitializeComponent();
            button_stop.Enabled = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;

            timer1.Tick += new EventHandler(ShowTimer);

            label_calend.Text = DateTime.Now.ToLongTimeString();

            timer2.Tick += new EventHandler(ShowTimer2);
            timer2.Interval = 500;
            timer2.Start();
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer1.Stop();
            button_stop.Enabled = false;
            MessageBox.Show("Timer stopped", "Timer");
        }

        private void ShowTimer2(object sender, EventArgs e)
        {
            label_calend.Text = DateTime.Now.ToLongTimeString();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if(timer_1.Value < 0)
            {
                MessageBox.Show("Error");
            }
            button_stop.Enabled = true;
            timer1.Interval = Decimal.ToInt32(timer_1.Value) * 1000;
            timer1.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Timer stopped before end of time", "Timer");
            button_stop.Enabled = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label_calend.Text = e.Start.ToShortDateString();
        }
    }
}
