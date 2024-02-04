namespace AGE.Vue.Formulaire.Liste
{
    partial class FrmSupprimerListe
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
            this.BouttonValider = new System.Windows.Forms.Button();
            this.ButtonAnuller = new System.Windows.Forms.Button();
            this.ComboBoxListeASuprimmer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BouttonValider
            // 
            this.BouttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BouttonValider.Image = global::AGE.Properties.Resources.Valider;
            this.BouttonValider.Location = new System.Drawing.Point(93, 106);
            this.BouttonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(73, 68);
            this.BouttonValider.TabIndex = 0;
            this.BouttonValider.UseVisualStyleBackColor = true;
            this.BouttonValider.Click += new System.EventHandler(this.BouttonValider_Click);
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(243, 106);
            this.ButtonAnuller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnuller.TabIndex = 1;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // ComboBoxListeASuprimmer
            // 
            this.ComboBoxListeASuprimmer.FormattingEnabled = true;
            this.ComboBoxListeASuprimmer.Location = new System.Drawing.Point(225, 43);
            this.ComboBoxListeASuprimmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxListeASuprimmer.Name = "ComboBoxListeASuprimmer";
            this.ComboBoxListeASuprimmer.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxListeASuprimmer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste à supprimer";
            // 
            // FrmSupprimerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxListeASuprimmer);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.BouttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSupprimerListe";
            this.Text = "FrmSupprimerListe";
            this.Load += new System.EventHandler(this.FrmSupprimerListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BouttonValider;
        private System.Windows.Forms.Button ButtonAnuller;
        private System.Windows.Forms.ComboBox ComboBoxListeASuprimmer;
        private System.Windows.Forms.Label label1;
    }
}