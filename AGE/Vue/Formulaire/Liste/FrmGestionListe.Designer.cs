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
            this.dateGridViewListe = new System.Windows.Forms.DataGridView();
            this.NomListe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importer une liste";
            // 
            // ButtonImport
            // 
            this.ButtonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImport.Image = global::AGE.Properties.Resources.ImporterList;
            this.ButtonImport.Location = new System.Drawing.Point(635, 374);
            this.ButtonImport.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(73, 68);
            this.ButtonImport.TabIndex = 1;
            this.ButtonImport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suprimer une liste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nouvelle liste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modifier une liste";
            // 
            // ButtonModiferListe
            // 
            this.ButtonModiferListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModiferListe.Image = global::AGE.Properties.Resources.ModifierListe;
            this.ButtonModiferListe.Location = new System.Drawing.Point(635, 162);
            this.ButtonModiferListe.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonModiferListe.Name = "ButtonModiferListe";
            this.ButtonModiferListe.Size = new System.Drawing.Size(73, 68);
            this.ButtonModiferListe.TabIndex = 5;
            this.ButtonModiferListe.UseVisualStyleBackColor = true;
            this.ButtonModiferListe.Click += new System.EventHandler(this.ButtonModiferListe_Click);
            // 
            // ButtonSuprimmerListe
            // 
            this.ButtonSuprimmerListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSuprimmerListe.Image = global::AGE.Properties.Resources.SuprimerListe;
            this.ButtonSuprimmerListe.Location = new System.Drawing.Point(635, 260);
            this.ButtonSuprimmerListe.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSuprimmerListe.Name = "ButtonSuprimmerListe";
            this.ButtonSuprimmerListe.Size = new System.Drawing.Size(73, 68);
            this.ButtonSuprimmerListe.TabIndex = 4;
            this.ButtonSuprimmerListe.UseVisualStyleBackColor = true;
            this.ButtonSuprimmerListe.Click += new System.EventHandler(this.ButtonSuprimmerListe_Click);
            // 
            // ButtonAjouterListe
            // 
            this.ButtonAjouterListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAjouterListe.Image = global::AGE.Properties.Resources.AjouterListe;
            this.ButtonAjouterListe.Location = new System.Drawing.Point(635, 68);
            this.ButtonAjouterListe.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAjouterListe.Name = "ButtonAjouterListe";
            this.ButtonAjouterListe.Size = new System.Drawing.Size(73, 68);
            this.ButtonAjouterListe.TabIndex = 3;
            this.ButtonAjouterListe.UseVisualStyleBackColor = true;
            this.ButtonAjouterListe.Click += new System.EventHandler(this.ButtonAjouterListe_Click);
            // 
            // dateGridViewListe
            // 
            this.dateGridViewListe.BackgroundColor = System.Drawing.Color.White;
            this.dateGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateGridViewListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomListe});
            this.dateGridViewListe.Location = new System.Drawing.Point(32, 25);
            this.dateGridViewListe.Margin = new System.Windows.Forms.Padding(4);
            this.dateGridViewListe.Name = "dateGridViewListe";
            this.dateGridViewListe.RowHeadersWidth = 51;
            this.dateGridViewListe.Size = new System.Drawing.Size(320, 398);
            this.dateGridViewListe.TabIndex = 9;
            // 
            // NomListe
            // 
            this.NomListe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomListe.HeaderText = "Nom de la liste ";
            this.NomListe.MinimumWidth = 6;
            this.NomListe.Name = "NomListe";
            this.NomListe.ReadOnly = true;
            this.NomListe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Location = new System.Drawing.Point(455, 40);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(75, 23);
            this.BtnActualiser.TabIndex = 10;
            this.BtnActualiser.Text = "Actualiser ";
            this.BtnActualiser.UseVisualStyleBackColor = true;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // FrmGestionListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.dateGridViewListe);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionListe";
            this.Text = "FrmGestionListe";
            this.Load += new System.EventHandler(this.FrmGestionListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateGridViewListe)).EndInit();
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
        private System.Windows.Forms.DataGridView dateGridViewListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomListe;
        private System.Windows.Forms.Button BtnActualiser;
    }
}