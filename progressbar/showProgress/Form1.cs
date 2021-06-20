using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace showProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Style = ProgressBarStyle.Marquee;
            status.Visible = false;
        }

        private async void startbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            status.Text = "Updating";
            status.Visible = true;
            await Task.Delay(2000);
            status.Text = "Loging in";
            await Task.Delay(2000);
            status.Text = "Selftest";
            await Task.Delay(2000);

            status.Text = "Updated";

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            status.Visible = false;
            status.Text = "canceled";
            
        }

        private void otherThread_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Another Thread!", "other thread", MessageBoxButtons.OK);
            string diskName = "I:\\";
            uint counterNoDiskWarning = 3;
            while (!Directory.Exists(diskName) & counterNoDiskWarning!= 0)
            {
                MessageBox.Show(string.Format("Please check if {0}", diskName), "Disk is not found", MessageBoxButtons.OK);
                counterNoDiskWarning--;
            }

            status.Text = "Other Thread";
            
        }
    }
}
