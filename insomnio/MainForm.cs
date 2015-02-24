using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insomnio
{
    public partial class frmInsomnio : Form
    {
        // Declare variables
        int moveX = 1;
        int delay = 240;
        int minTime = 1;
        int maxTime = 300;
        int tickFreq = 100;
        double opacity = 100;

        public frmInsomnio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkEnableDisable.Checked = false;
            EnableDisable();
            InitializeTrackBar();
            InitGUI();
        }

        public void InitGUI()
        {
            this.Text = "Insomnio 1.0 © 2015 Jörgen Bertholdsson";
            this.Size = new Size(374, 93); 
            lblOpacity.Text = "Opacity";
            trkOpacity.Value = (int)opacity;
            trkTime.Value = delay;
            if (delay > 1)
            {
                lblSeconds.Text = delay.ToString() + " sekunder"; 
            }
            else 
            { 
                lblSeconds.Text = delay.ToString() + " sekund"; 
            }
        }
        
        public void EnableDisable()
        {
            if (chkEnableDisable.Checked)
            { 
                timMove.Interval = delay * 1000;
                timMove.Enabled = true;
            }
            else
            { 
                timMove.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void MoveCursor()
        {
            System.Windows.Forms.SendKeys.SendWait("+");
            if (moveX == 1) { moveX = -1; }
            else { moveX = 1; }
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - moveX, Cursor.Position.Y);
        }

        private void timMove_Tick(object sender, EventArgs e)
        {
            MoveCursor();
        }

        private void trkTime_Scroll(object sender, EventArgs e)
        {
            //
        }

        private void trkTime_RightToLeftChanged(object sender, EventArgs e)
        {
            //
        }

        private void trkTime_ValueChanged(object sender, EventArgs e)
        {
            delay = (int)(System.Math.Round(trkTime.Value / 1.0));
            timMove.Interval = delay * 1000;
             if (delay > 1) { lblSeconds.Text = delay.ToString() + " sekunder"; }
            else { lblSeconds.Text = delay.ToString() + " sekund"; }
        }

        private void trkOpacity_ValueChanged(object sender, EventArgs e)
        {
            opacity = (System.Math.Round(trkOpacity.Value / 1.0));
            this.Opacity = opacity / 100; 
        }


        private void InitializeTrackBar()
        {
            trkTime.TickStyle = TickStyle.None;
            trkTime.Minimum = minTime;
            trkTime.Maximum = maxTime;
            trkTime.TickFrequency = tickFreq;
        }

        private void chkMore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMore.Checked)
            {
                this.Size = new Size(374, 150);
            }
            else
            {
                this.Size = new Size(374, 93);
            }
        }
    }
}
