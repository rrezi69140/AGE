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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNomList = new System.Windows.Forms.Label();
            this.BouttonValider = new System.Windows.Forms.Button();
            this.ButtonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 0;
            // 
            // labelNomList
            // 
            this.labelNomList.AutoSize = true;
            this.labelNomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomList.Location = new System.Drawing.Point(12, 32);
            this.labelNomList.Name = "labelNomList";
            this.labelNomList.Size = new System.Drawing.Size(144, 24);
            this.labelNomList.TabIndex = 1;
            this.labelNomList.Text = "Nom de la liste :";
            // 
            // BouttonValider
            // 
            this.BouttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BouttonValider.Image = global::AGE.Properties.Resources.Valider;
            this.BouttonValider.Location = new System.Drawing.Point(259, 92);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Size = new System.Drawing.Size(55, 55);
            this.BouttonValider.TabIndex = 2;
            this.BouttonValider.UseVisualStyleBackColor = true;
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnnuler.Image = global::AGE.Properties.Resources.Anuller;
            this.ButtonAnnuler.Location = new System.Drawing.Point(351, 92);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(55, 55);
            this.ButtonAnnuler.TabIndex = 3;
            this.ButtonAnnuler.UseVisualStyleBackColor = true;
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // FrmNouvelleListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 183);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.BouttonValider);
            this.Controls.Add(this.labelNomList);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNouvelleListe";
            this.Text = "FrmNouvelleListe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNomList;
        private System.Windows.Forms.Button BouttonValider;
        private System.Windows.Forms.Button ButtonAnnuler;
    }
}