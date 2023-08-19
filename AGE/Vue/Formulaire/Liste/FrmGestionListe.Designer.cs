namespace AGE.Vue.Formulaire
{
    partial class FrmGestionListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionListe));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonModiferListe = new System.Windows.Forms.Button();
            this.ButtonSuprimmerListe = new System.Windows.Forms.Button();
            this.ButtonAjouterListe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importer une liste";
            // 
            // ButtonImport
            // 
            this.ButtonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImport.Image = global::AGE.Properties.Resources.ImporterList;
            this.ButtonImport.Location = new System.Drawing.Point(534, 288);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(55, 55);
            this.ButtonImport.TabIndex = 1;
            this.ButtonImport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suprimer une liste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nouvelle liste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modifier une liste";
            // 
            // ButtonModiferListe
            // 
            this.ButtonModiferListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModiferListe.Image = global::AGE.Properties.Resources.ModifierListe;
            this.ButtonModiferListe.Location = new System.Drawing.Point(534, 133);
            this.ButtonModiferListe.Name = "ButtonModiferListe";
            this.ButtonModiferListe.Size = new System.Drawing.Size(55, 55);
            this.ButtonModiferListe.TabIndex = 5;
            this.ButtonModiferListe.UseVisualStyleBackColor = true;
            // 
            // ButtonSuprimmerListe
            // 
            this.ButtonSuprimmerListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSuprimmerListe.Image = global::AGE.Properties.Resources.SuprimerListe;
            this.ButtonSuprimmerListe.Location = new System.Drawing.Point(534, 212);
            this.ButtonSuprimmerListe.Name = "ButtonSuprimmerListe";
            this.ButtonSuprimmerListe.Size = new System.Drawing.Size(55, 55);
            this.ButtonSuprimmerListe.TabIndex = 4;
            this.ButtonSuprimmerListe.UseVisualStyleBackColor = true;
            // 
            // ButtonAjouterListe
            // 
            this.ButtonAjouterListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAjouterListe.Image = global::AGE.Properties.Resources.AjouterListe;
            this.ButtonAjouterListe.Location = new System.Drawing.Point(534, 56);
            this.ButtonAjouterListe.Name = "ButtonAjouterListe";
            this.ButtonAjouterListe.Size = new System.Drawing.Size(55, 55);
            this.ButtonAjouterListe.TabIndex = 3;
            this.ButtonAjouterListe.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 323);
            this.dataGridView1.TabIndex = 9;
            // 
            // FrmGestionListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonModiferListe);
            this.Controls.Add(this.ButtonSuprimmerListe);
            this.Controls.Add(this.ButtonAjouterListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionListe";
            this.Text = "FrmGestionListe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAjouterListe;
        private System.Windows.Forms.Button ButtonSuprimmerListe;
        private System.Windows.Forms.Button ButtonModiferListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}