namespace AGE.Vue.Formulaire.Effectif
{
    partial class FrmSupprimerEnfant
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxEnfantASuprimmer = new System.Windows.Forms.ComboBox();
            this.ButtonAnuller = new System.Windows.Forms.Button();
            this.BouttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enfant à supprimer";
            // 
            // ComboBoxEnfantASuprimmer
            // 
            this.ComboBoxEnfantASuprimmer.FormattingEnabled = true;
            this.ComboBoxEnfantASuprimmer.Location = new System.Drawing.Point(261, 46);
            this.ComboBoxEnfantASuprimmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxEnfantASuprimmer.Name = "ComboBoxEnfantASuprimmer";
            this.ComboBoxEnfantASuprimmer.Size = new System.Drawing.Size(355, 24);
            this.ComboBoxEnfantASuprimmer.TabIndex = 6;
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(112, 128);
            this.ButtonAnuller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnuller.TabIndex = 5;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // BouttonValider
            // 
            this.BouttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BouttonValider.Image = global::AGE.Properties.Resources.Valider;
            this.BouttonValider.Location = new System.Drawing.Point(13, 128);
            this.BouttonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(73, 68);
            this.BouttonValider.TabIndex = 4;
            this.BouttonValider.UseVisualStyleBackColor = true;
            this.BouttonValider.Click += new System.EventHandler(this.BouttonValider_Click);
            // 
            // FrmSupprimerEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxEnfantASuprimmer);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.BouttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSupprimerEnfant";
            this.Text = "FrmSupprimerEnfant";
            this.Load += new System.EventHandler(this.FrmSupprimerEnfant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxEnfantASuprimmer;
        private System.Windows.Forms.Button ButtonAnuller;
        private System.Windows.Forms.Button BouttonValider;
    }
}