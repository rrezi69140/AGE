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
            this.TextBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.ButtonAnuller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de Naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numeros de dossier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom :";
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrenom.Location = new System.Drawing.Point(119, 37);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(174, 22);
            this.TextBoxPrenom.TabIndex = 4;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNom.Location = new System.Drawing.Point(119, 74);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(174, 22);
            this.TextBoxNom.TabIndex = 5;
            // 
            // TextBoxNumDossier
            // 
            this.TextBoxNumDossier.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNumDossier.Location = new System.Drawing.Point(500, 40);
            this.TextBoxNumDossier.Name = "TextBoxNumDossier";
            this.TextBoxNumDossier.Size = new System.Drawing.Size(174, 22);
            this.TextBoxNumDossier.TabIndex = 6;
            // 
            // TextBoxDateNaissance
            // 
            this.TextBoxDateNaissance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDateNaissance.Location = new System.Drawing.Point(500, 82);
            this.TextBoxDateNaissance.Name = "TextBoxDateNaissance";
            this.TextBoxDateNaissance.Size = new System.Drawing.Size(174, 22);
            this.TextBoxDateNaissance.TabIndex = 7;
            // 
            // ButtonValider
            // 
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Image = global::AGE.Properties.Resources.Valider;
            this.ButtonValider.Location = new System.Drawing.Point(517, 148);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(55, 55);
            this.ButtonValider.TabIndex = 8;
            this.ButtonValider.UseVisualStyleBackColor = true;
            // 
            // ButtonAnuller
            // 
            this.ButtonAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuller.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuller.Location = new System.Drawing.Point(619, 148);
            this.ButtonAnuller.Name = "ButtonAnuller";
            this.ButtonAnuller.Size = new System.Drawing.Size(55, 55);
            this.ButtonAnuller.TabIndex = 9;
            this.ButtonAnuller.UseVisualStyleBackColor = true;
            this.ButtonAnuller.Click += new System.EventHandler(this.ButtonAnuller_Click);
            // 
            // FrmAjouterEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 227);
            this.Controls.Add(this.ButtonAnuller);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.TextBoxDateNaissance);
            this.Controls.Add(this.TextBoxNumDossier);
            this.Controls.Add(this.TextBoxNom);
            this.Controls.Add(this.TextBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAjouterEnfant";
            this.Text = "FrmAjouterEnfant";
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
        private System.Windows.Forms.TextBox TextBoxDateNaissance;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Button ButtonAnuller;
    }
}