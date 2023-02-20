
namespace Splash_Screen
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopToBottomTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftToRightTimer = new System.Windows.Forms.Timer(this.components);
            this.TopToBottomPanel = new System.Windows.Forms.Panel();
            this.TopToBottomPanel2 = new System.Windows.Forms.Panel();
            this.LeftToRightPanel = new System.Windows.Forms.Panel();
            this.LeftToRightPanel2 = new System.Windows.Forms.Panel();
            this.TopToBottomTimer2 = new System.Windows.Forms.Timer(this.components);
            this.LeftToRightTimer2 = new System.Windows.Forms.Timer(this.components);
            this.lblwelcome = new System.Windows.Forms.Label();
            this.WordTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopToBottomTimer
            // 
            this.TopToBottomTimer.Enabled = true;
            this.TopToBottomTimer.Interval = 15;
            this.TopToBottomTimer.Tick += new System.EventHandler(this.SSLeftTimer_Tick);
            // 
            // LeftToRightTimer
            // 
            this.LeftToRightTimer.Enabled = true;
            this.LeftToRightTimer.Interval = 15;
            this.LeftToRightTimer.Tick += new System.EventHandler(this.BottomToTopTimer_Tick);
            // 
            // TopToBottomPanel
            // 
            this.TopToBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.TopToBottomPanel.Location = new System.Drawing.Point(44, -1);
            this.TopToBottomPanel.Name = "TopToBottomPanel";
            this.TopToBottomPanel.Size = new System.Drawing.Size(19, 17);
            this.TopToBottomPanel.TabIndex = 1;
            // 
            // TopToBottomPanel2
            // 
            this.TopToBottomPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.TopToBottomPanel2.Location = new System.Drawing.Point(729, -1);
            this.TopToBottomPanel2.Name = "TopToBottomPanel2";
            this.TopToBottomPanel2.Size = new System.Drawing.Size(19, 17);
            this.TopToBottomPanel2.TabIndex = 1;
            this.TopToBottomPanel2.Visible = false;
            // 
            // LeftToRightPanel
            // 
            this.LeftToRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.LeftToRightPanel.Location = new System.Drawing.Point(0, 37);
            this.LeftToRightPanel.Name = "LeftToRightPanel";
            this.LeftToRightPanel.Size = new System.Drawing.Size(17, 19);
            this.LeftToRightPanel.TabIndex = 3;
            this.LeftToRightPanel.Visible = false;
            // 
            // LeftToRightPanel2
            // 
            this.LeftToRightPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(167)))));
            this.LeftToRightPanel2.Location = new System.Drawing.Point(0, 437);
            this.LeftToRightPanel2.Name = "LeftToRightPanel2";
            this.LeftToRightPanel2.Size = new System.Drawing.Size(17, 19);
            this.LeftToRightPanel2.TabIndex = 4;
            // 
            // TopToBottomTimer2
            // 
            this.TopToBottomTimer2.Interval = 15;
            this.TopToBottomTimer2.Tick += new System.EventHandler(this.TopToBottomTimer2_Tick);
            // 
            // LeftToRightTimer2
            // 
            this.LeftToRightTimer2.Interval = 15;
            this.LeftToRightTimer2.Tick += new System.EventHandler(this.LeftToRightTimer2_Tick);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblwelcome.Location = new System.Drawing.Point(166, 236);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(414, 39);
            this.lblwelcome.TabIndex = 5;
            this.lblwelcome.Text = "Welcome To Anondo Bazar";
            // 
            // WordTimer
            // 
            this.WordTimer.Tick += new System.EventHandler(this.WordTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Splash_Screen.Properties.Resources.anondoBazar;
            this.pictureBox1.Location = new System.Drawing.Point(280, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.LeftToRightPanel2);
            this.Controls.Add(this.LeftToRightPanel);
            this.Controls.Add(this.TopToBottomPanel2);
            this.Controls.Add(this.TopToBottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TopToBottomTimer;
        private System.Windows.Forms.Timer LeftToRightTimer;
        private System.Windows.Forms.Panel TopToBottomPanel;
        private System.Windows.Forms.Panel TopToBottomPanel2;
        private System.Windows.Forms.Panel LeftToRightPanel;
        private System.Windows.Forms.Panel LeftToRightPanel2;
        private System.Windows.Forms.Timer TopToBottomTimer2;
        private System.Windows.Forms.Timer LeftToRightTimer2;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Timer WordTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

