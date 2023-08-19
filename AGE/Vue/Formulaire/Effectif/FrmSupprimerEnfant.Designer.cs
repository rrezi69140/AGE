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
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enfant à supprimer";
            // 
            // ComboBoxEnfantASuprimmer
            // 
            this.ComboBoxEnfantASuprimmer.FormattingEnabled = true;
            this.ComboBoxEnfantASuprimmer.Location = new System.Drawing.Point(183, 33);
            this.ComboBoxEnfantASuprimmer.Name = "ComboBoxEnfantASuprimmer";
            this.ComboBoxEnfantASuprimmer.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxEnfantASuprimmer.TabIndex = 6;
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(196, 84);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(55, 55);
            this.ButtonAnuller.TabIndex = 5;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            // 
            // BouttonValider
            // 
            this.BouttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BouttonValider.Image = global::AGE.Properties.Resources.Valider;
            this.BouttonValider.Location = new System.Drawing.Point(84, 84);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(55, 55);
            this.BouttonValider.TabIndex = 4;
            this.BouttonValider.UseVisualStyleBackColor = true;
            // 
            // FrmSupprimerEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxEnfantASuprimmer);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.BouttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSupprimerEnfant";
            this.Text = "FrmSupprimerEnfant";
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