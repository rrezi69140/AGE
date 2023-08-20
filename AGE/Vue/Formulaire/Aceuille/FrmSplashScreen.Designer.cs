namespace AGE.Vue.Formulaire.Aceuille
{
    partial class FrmSplashScreen
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
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgresseBare = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 900;
            this.SplashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgresseBare
            // 
            this.ProgresseBare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgresseBare.Location = new System.Drawing.Point(174, 283);
            this.ProgresseBare.Name = "ProgresseBare";
            this.ProgresseBare.Size = new System.Drawing.Size(456, 23);
            this.ProgresseBare.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgresseBare.TabIndex = 0;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AGE.Properties.Resources.AGE;
            this.ClientSize = new System.Drawing.Size(817, 492);
            this.Controls.Add(this.ProgresseBare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.ProgressBar ProgresseBare;
    }
}