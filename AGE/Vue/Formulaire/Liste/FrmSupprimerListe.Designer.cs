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
            this.BouttonValider.Location = new System.Drawing.Point(70, 86);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(55, 55);
            this.BouttonValider.TabIndex = 0;
            this.BouttonValider.UseVisualStyleBackColor = true;
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(182, 86);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(55, 55);
            this.ButtonAnuller.TabIndex = 1;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // ComboBoxListeASuprimmer
            // 
            this.ComboBoxListeASuprimmer.FormattingEnabled = true;
            this.ComboBoxListeASuprimmer.Location = new System.Drawing.Point(169, 35);
            this.ComboBoxListeASuprimmer.Name = "ComboBoxListeASuprimmer";
            this.ComboBoxListeASuprimmer.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxListeASuprimmer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste à supprimer";
            // 
            // FrmSupprimerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxListeASuprimmer);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.BouttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSupprimerListe";
            this.Text = "FrmSupprimerListe";
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