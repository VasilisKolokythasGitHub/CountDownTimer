using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        TimeSpan timeLeft = new TimeSpan(0, 0, 14, 0); 

        private void timer1_Tick(object sender, EventArgs e)
        {

                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));  
                timerlabel.Text = timeLeft.ToString(@"hh\:mm\:ss");

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int enteredMinutes = Int32.Parse(inputMinutes.Text);
            timeLeft = new TimeSpan(0, 0, enteredMinutes, 0);
            timerlabel.Text = timeLeft.ToString(@"hh\:mm\:ss");
            timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int enteredMinutes = Int32.Parse(inputMinutes.Text);
            timeLeft =  new TimeSpan(0, 0, enteredMinutes, 0);
            timerlabel.Text = timeLeft.ToString(@"hh\:mm\:ss");
        }

        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
