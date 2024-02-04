namespace AGE.Vue.Formulaire.Liste
{
    partial class FrmModifierListe
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
            this.ButtonValider = new System.Windows.Forms.Button();
            this.ButtonAnuler = new System.Windows.Forms.Button();
            this.ComboLIsteAModifier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNomListe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonValider
            // 
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Image = global::AGE.Properties.Resources.Valider;
            this.ButtonValider.Location = new System.Drawing.Point(291, 219);
            this.ButtonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(73, 68);
            this.ButtonValider.TabIndex = 0;
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // ButtonAnuler
            // 
            this.ButtonAnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuler.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuler.Location = new System.Drawing.Point(143, 219);
            this.ButtonAnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAnuler.Name = "ButtonAnuler";
            this.ButtonAnuler.Size = new System.Drawing.Size(73, 68);
            this.ButtonAnuler.TabIndex = 1;
            this.ButtonAnuler.UseVisualStyleBackColor = true;
            this.ButtonAnuler.Click += new System.EventHandler(this.ButtonAnuler_Click);
            // 
            // ComboLIsteAModifier
            // 
            this.ComboLIsteAModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLIsteAModifier.FormattingEnabled = true;
            this.ComboLIsteAModifier.Location = new System.Drawing.Point(263, 78);
            this.ComboLIsteAModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboLIsteAModifier.Name = "ComboLIsteAModifier";
            this.ComboLIsteAModifier.Size = new System.Drawing.Size(160, 28);
            this.ComboLIsteAModifier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste a modifier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "NouveauNom :";
            // 
            // TextBoxNomListe
            // 
            this.TextBoxNomListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNomListe.Location = new System.Drawing.Point(224, 148);
            this.TextBoxNomListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNomListe.Name = "TextBoxNomListe";
            this.TextBoxNomListe.Size = new System.Drawing.Size(239, 26);
            this.TextBoxNomListe.TabIndex = 5;
            // 
            // FrmModifierListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 332);
            this.Controls.Add(this.TextBoxNomListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboLIsteAModifier);
            this.Controls.Add(this.ButtonAnuler);
            this.Controls.Add(this.ButtonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmModifierListe";
            this.Text = "ModifierListe";
            this.Load += new System.EventHandler(this.FrmModifierListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Button ButtonAnuler;
        private System.Windows.Forms.ComboBox ComboLIsteAModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNomListe;
    }
}