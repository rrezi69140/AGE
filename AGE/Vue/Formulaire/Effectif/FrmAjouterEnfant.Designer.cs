namespace AGE.Vue.Formulaire.Effectif
{
    partial class FrmAjouterEnfant
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxNumDossier = new System.Windows.Forms.TextBox();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.ButtonAnuller = new System.Windows.Forms.Button();
            this.ComboBoxSelectionBus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxSelectionGroupe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de Naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numeros de dossier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom :";
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Font = new System.Drawing.Font("Arial", 13.8F);
            this.TextBoxPrenom.Location = new System.Drawing.Point(277, 135);
            this.TextBoxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(231, 34);
            this.TextBoxPrenom.TabIndex = 4;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Font = new System.Drawing.Font("Arial", 13.8F);
            this.TextBoxNom.Location = new System.Drawing.Point(277, 200);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(231, 34);
            this.TextBoxNom.TabIndex = 5;
            // 
            // TextBoxNumDossier
            // 
            this.TextBoxNumDossier.Font = new System.Drawing.Font("Arial", 13.8F);
            this.TextBoxNumDossier.Location = new System.Drawing.Point(277, 66);
            this.TextBoxNumDossier.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNumDossier.Name = "TextBoxNumDossier";
            this.TextBoxNumDossier.Size = new System.Drawing.Size(231, 34);
            this.TextBoxNumDossier.TabIndex = 6;
            // 
            // ButtonValider
            // 
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Image = global::AGE.Properties.Resources.Valider;
            this.ButtonValider.Location = new System.Drawing.Point(119, 451);
            this.ButtonValider.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(73, 68);
            this.ButtonValider.TabIndex = 8;
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(253, 451);
            this.ButtonAnuller.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnuller.TabIndex = 9;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // ComboBoxSelectionBus
            // 
            this.ComboBoxSelectionBus.Font = new System.Drawing.Font("Arial", 13.8F);
            this.ComboBoxSelectionBus.FormattingEnabled = true;
            this.ComboBoxSelectionBus.Location = new System.Drawing.Point(277, 334);
            this.ComboBoxSelectionBus.Name = "ComboBoxSelectionBus";
            this.ComboBoxSelectionBus.Size = new System.Drawing.Size(231, 34);
            this.ComboBoxSelectionBus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bus:";
            // 
            // ComboBoxSelectionGroupe
            // 
            this.ComboBoxSelectionGroupe.Font = new System.Drawing.Font("Arial", 13.8F);
            this.ComboBoxSelectionGroupe.FormattingEnabled = true;
            this.ComboBoxSelectionGroupe.Location = new System.Drawing.Point(277, 390);
            this.ComboBoxSelectionGroupe.Name = "ComboBoxSelectionGroupe";
            this.ComboBoxSelectionGroupe.Size = new System.Drawing.Size(231, 34);
            this.ComboBoxSelectionGroupe.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Groupe :";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Location = new System.Drawing.Point(277, 272);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(305, 30);
            this.DateTimePicker.TabIndex = 15;
            // 
            // FrmAjouterEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 615);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxSelectionGroupe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxSelectionBus);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjouterEnfant";
            this.Text = "FrmAjouterEnfant";
            this.Load += new System.EventHandler(this.FrmAjouterEnfant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPrenom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.TextBox TextBoxNumDossier;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Button ButtonAnuller;
        private System.Windows.Forms.ComboBox ComboBoxSelectionBus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxSelectionGroupe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}