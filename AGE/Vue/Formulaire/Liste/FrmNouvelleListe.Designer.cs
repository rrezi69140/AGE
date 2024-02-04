namespace AGE.Vue.Formulaire.Liste
{
    partial class FrmNouvelleListe
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
            this.labelNomList = new System.Windows.Forms.Label();
            this.BouttonValider = new System.Windows.Forms.Button();
            this.ButtonAnnuler = new System.Windows.Forms.Button();
            this.TextBoxAjouterListe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNomList
            // 
            this.labelNomList.AutoSize = true;
            this.labelNomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomList.Location = new System.Drawing.Point(16, 39);
            this.labelNomList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomList.Name = "labelNomList";
            this.labelNomList.Size = new System.Drawing.Size(186, 29);
            this.labelNomList.TabIndex = 1;
            this.labelNomList.Text = "Nom de la liste :";
            // 
            // BouttonValider
            // 
            this.BouttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BouttonValider.Image = global::AGE.Properties.Resources.Valider;
            this.BouttonValider.Location = new System.Drawing.Point(345, 113);
            this.BouttonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(73, 68);
            this.BouttonValider.TabIndex = 2;
            this.BouttonValider.UseVisualStyleBackColor = true;
            this.BouttonValider.Click += new System.EventHandler(this.BouttonValider_Click);
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnnuler.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnnuler.Location = new System.Drawing.Point(468, 113);
            this.ButtonAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnnuler.TabIndex = 3;
            this.ButtonAnnuler.UseVisualStyleBackColor = true;
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // TextBoxAjouterListe
            // 
            this.TextBoxAjouterListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAjouterListe.Location = new System.Drawing.Point(216, 43);
            this.TextBoxAjouterListe.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAjouterListe.Name = "TextBoxAjouterListe";
            this.TextBoxAjouterListe.Size = new System.Drawing.Size(416, 26);
            this.TextBoxAjouterListe.TabIndex = 0;
            // 
            // FrmNouvelleListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 225);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.BouttonValider);
            this.Controls.Add(this.labelNomList);
            this.Controls.Add(this.TextBoxAjouterListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNouvelleListe";
            this.Text = "FrmNouvelleListe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomList;
        private System.Windows.Forms.Button BouttonValider;
        private System.Windows.Forms.Button ButtonAnnuler;
        private System.Windows.Forms.TextBox TextBoxAjouterListe;
    }
}