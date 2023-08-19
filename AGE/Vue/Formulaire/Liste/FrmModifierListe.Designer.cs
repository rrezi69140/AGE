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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonValider
            // 
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Image = global::AGE.Properties.Resources.Valider;
            this.ButtonValider.Location = new System.Drawing.Point(218, 178);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(55, 55);
            this.ButtonValider.TabIndex = 0;
            this.ButtonValider.UseVisualStyleBackColor = true;
            // 
            // ButtonAnuler
            // 
            this.ButtonAnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuler.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnuler.Location = new System.Drawing.Point(107, 178);
            this.ButtonAnuler.Name = "ButtonAnuler";
            this.ButtonAnuler.Size = new System.Drawing.Size(55, 55);
            this.ButtonAnuler.TabIndex = 1;
            this.ButtonAnuler.UseVisualStyleBackColor = true;
            this.ButtonAnuler.Click += new System.EventHandler(this.ButtonAnuler_Click);
            // 
            // ComboLIsteAModifier
            // 
            this.ComboLIsteAModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLIsteAModifier.FormattingEnabled = true;
            this.ComboLIsteAModifier.Location = new System.Drawing.Point(197, 63);
            this.ComboLIsteAModifier.Name = "ComboLIsteAModifier";
            this.ComboLIsteAModifier.Size = new System.Drawing.Size(121, 24);
            this.ComboLIsteAModifier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste a modifier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "NouveauNom :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 5;
            // 
            // FrmModifierListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 270);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboLIsteAModifier);
            this.Controls.Add(this.ButtonAnuler);
            this.Controls.Add(this.ButtonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmModifierListe";
            this.Text = "ModifierListe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Button ButtonAnuler;
        private System.Windows.Forms.ComboBox ComboLIsteAModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}