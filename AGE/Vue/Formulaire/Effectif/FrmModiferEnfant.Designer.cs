namespace AGE.Vue.Formulaire.Effectif
{
    partial class FrmModiferEnfant
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
            this.ButtonAnuller = new System.Windows.Forms.Button();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.TextBoxNumDossier = new System.Windows.Forms.TextBox();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxEnfantAModifier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePIckerDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxGroupe = new System.Windows.Forms.ComboBox();
            this.ComboBoxBus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(781, 254);
            this.ButtonAnuller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnuller.TabIndex = 19;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Image = global::AGE.Properties.Resources.Valider;
            this.ButtonValider.Location = new System.Drawing.Point(659, 254);
            this.ButtonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(73, 68);
            this.ButtonValider.TabIndex = 18;
            this.ButtonValider.UseVisualStyleBackColor = true;
            // 
            // TextBoxNumDossier
            // 
            this.TextBoxNumDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNumDossier.Location = new System.Drawing.Point(677, 116);
            this.TextBoxNumDossier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNumDossier.Name = "TextBoxNumDossier";
            this.TextBoxNumDossier.Size = new System.Drawing.Size(231, 26);
            this.TextBoxNumDossier.TabIndex = 16;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNom.Location = new System.Drawing.Point(151, 162);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(231, 26);
            this.TextBoxNom.TabIndex = 15;
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrenom.Location = new System.Drawing.Point(151, 117);
            this.TextBoxPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(231, 26);
            this.TextBoxPrenom.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numeros de dossier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date de Naissance :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prenom :";
            // 
            // ComboBoxEnfantAModifier
            // 
            this.ComboBoxEnfantAModifier.FormattingEnabled = true;
            this.ComboBoxEnfantAModifier.Location = new System.Drawing.Point(521, 48);
            this.ComboBoxEnfantAModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxEnfantAModifier.Name = "ComboBoxEnfantAModifier";
            this.ComboBoxEnfantAModifier.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxEnfantAModifier.TabIndex = 20;
            this.ComboBoxEnfantAModifier.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEnfantAModifier_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Enfant à modifier";
            // 
            // DateTimePIckerDateNaissance
            // 
            this.DateTimePIckerDateNaissance.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePIckerDateNaissance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePIckerDateNaissance.Location = new System.Drawing.Point(677, 171);
            this.DateTimePIckerDateNaissance.Name = "DateTimePIckerDateNaissance";
            this.DateTimePIckerDateNaissance.Size = new System.Drawing.Size(200, 27);
            this.DateTimePIckerDateNaissance.TabIndex = 22;
            // 
            // ComboBoxGroupe
            // 
            this.ComboBoxGroupe.Font = new System.Drawing.Font("Arial", 13.8F);
            this.ComboBoxGroupe.FormattingEnabled = true;
            this.ComboBoxGroupe.Location = new System.Drawing.Point(151, 226);
            this.ComboBoxGroupe.Name = "ComboBoxGroupe";
            this.ComboBoxGroupe.Size = new System.Drawing.Size(231, 34);
            this.ComboBoxGroupe.TabIndex = 23;
            // 
            // ComboBoxBus
            // 
            this.ComboBoxBus.Font = new System.Drawing.Font("Arial", 13.8F);
            this.ComboBoxBus.FormattingEnabled = true;
            this.ComboBoxBus.Location = new System.Drawing.Point(150, 288);
            this.ComboBoxBus.Name = "ComboBoxBus";
            this.ComboBoxBus.Size = new System.Drawing.Size(231, 34);
            this.ComboBoxBus.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Groupe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Bus :";
            // 
            // FrmModiferEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxBus);
            this.Controls.Add(this.ComboBoxGroupe);
            this.Controls.Add(this.DateTimePIckerDateNaissance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxEnfantAModifier);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.TextBoxNumDossier);
            this.Controls.Add(this.TextBoxNom);
            this.Controls.Add(this.TextBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmModiferEnfant";
            this.Text = "FrmModiferEnfant";
            this.Load += new System.EventHandler(this.FrmModiferEnfant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnuller;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.TextBox TextBoxNumDossier;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.TextBox TextBoxPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxEnfantAModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimePIckerDateNaissance;
        private System.Windows.Forms.ComboBox ComboBoxGroupe;
        private System.Windows.Forms.ComboBox ComboBoxBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}