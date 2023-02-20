using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class SplashScreen : Form
    {
        private string text;
        private int len = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            text = lblwelcome.Text;
            lblwelcome.Text = "";
            WordTimer.Start();
        }

        private void SSLeftTimer_Tick(object sender, EventArgs e)
        {
            TopToBottomPanel.Height += 3;
            if (TopToBottomPanel.Height >= 550)
            {
                TopToBottomTimer.Stop();
                TopToBottomPanel2.Visible = true;
                TopToBottomTimer2.Start();
                LeftToRightPanel.Visible = true;
                LeftToRightTimer2.Start();
            }
        }

        private void BottomToTopTimer_Tick(object sender, EventArgs e)
        {
            LeftToRightPanel2.Width += 5;
            if(TopToBottomPanel2.Height >= 784)
            {
                LeftToRightTimer.Stop();
            }
        }

        private void TopToBottomTimer2_Tick(object sender, EventArgs e)
        {
            TopToBottomPanel2.Height += 3;
            if(TopToBottomPanel2.Height >= 550)
            {
                TopToBottomTimer2.Stop();
            }
        }

        private void LeftToRightTimer2_Tick(object sender, EventArgs e)
        {
            LeftToRightPanel.Width += 5;
            if(LeftToRightPanel.Width >= 784)
            {
                LeftToRightTimer2.Stop();

                AfterSplash fm = new AfterSplash();
                fm.Show();
                this.Hide();
            }
        }

        private void WordTimer_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblwelcome.Text = lblwelcome.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                WordTimer.Stop();
            }
        }
    }
}
