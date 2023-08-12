namespace AGE.Vue.Formulaire
{
    partial class FrmGestionEffectif
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEffectif));
            this.ComboBoxGroupe = new System.Windows.Forms.ComboBox();
            this.ComboBoxBus = new System.Windows.Forms.ComboBox();
            this.ButtonExportGroupe = new System.Windows.Forms.Button();
            this.ButtonGroupeOk = new System.Windows.Forms.Button();
            this.ButtonBusOk = new System.Windows.Forms.Button();
            this.LabelGroupeSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTitreFOrm = new System.Windows.Forms.Label();
            this.DataGridViewEnfant = new System.Windows.Forms.DataGridView();
            this.NumDossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnfant)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxGroupe
            // 
            this.ComboBoxGroupe.FormattingEnabled = true;
            this.ComboBoxGroupe.Location = new System.Drawing.Point(746, 122);
            this.ComboBoxGroupe.Name = "ComboBoxGroupe";
            this.ComboBoxGroupe.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxGroupe.TabIndex = 1;
            // 
            // ComboBoxBus
            // 
            this.ComboBoxBus.FormattingEnabled = true;
            this.ComboBoxBus.Location = new System.Drawing.Point(746, 203);
            this.ComboBoxBus.Name = "ComboBoxBus";
            this.ComboBoxBus.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBus.TabIndex = 2;
            // 
            // ButtonExportGroupe
            // 
            this.ButtonExportGroupe.Location = new System.Drawing.Point(938, 122);
            this.ButtonExportGroupe.Name = "ButtonExportGroupe";
            this.ButtonExportGroupe.Size = new System.Drawing.Size(75, 23);
            this.ButtonExportGroupe.TabIndex = 3;
            this.ButtonExportGroupe.Text = "Exporter";
            this.ButtonExportGroupe.UseVisualStyleBackColor = true;
            this.ButtonExportGroupe.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonGroupeOk
            // 
            this.ButtonGroupeOk.Location = new System.Drawing.Point(889, 122);
            this.ButtonGroupeOk.Name = "ButtonGroupeOk";
            this.ButtonGroupeOk.Size = new System.Drawing.Size(34, 23);
            this.ButtonGroupeOk.TabIndex = 4;
            this.ButtonGroupeOk.Text = "OK";
            this.ButtonGroupeOk.UseVisualStyleBackColor = true;
            this.ButtonGroupeOk.Click += new System.EventHandler(this.ButtonGroupeOk_Click);
            // 
            // ButtonBusOk
            // 
            this.ButtonBusOk.Location = new System.Drawing.Point(889, 201);
            this.ButtonBusOk.Name = "ButtonBusOk";
            this.ButtonBusOk.Size = new System.Drawing.Size(34, 23);
            this.ButtonBusOk.TabIndex = 5;
            this.ButtonBusOk.Text = "OK";
            this.ButtonBusOk.UseVisualStyleBackColor = true;
            this.ButtonBusOk.Click += new System.EventHandler(this.ButtonBusOk_Click);
            // 
            // LabelGroupeSelect
            // 
            this.LabelGroupeSelect.AutoSize = true;
            this.LabelGroupeSelect.BackColor = System.Drawing.Color.Transparent;
            this.LabelGroupeSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.LabelGroupeSelect.Location = new System.Drawing.Point(743, 90);
            this.LabelGroupeSelect.Name = "LabelGroupeSelect";
            this.LabelGroupeSelect.Size = new System.Drawing.Size(156, 13);
            this.LabelGroupeSelect.TabIndex = 6;
            this.LabelGroupeSelect.Text = "Afficher le groupe selectionner :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(743, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Afficher le Bus selectionner :";
            // 
            // LabelTitreFOrm
            // 
            this.LabelTitreFOrm.AutoSize = true;
            this.LabelTitreFOrm.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitreFOrm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitreFOrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.LabelTitreFOrm.Location = new System.Drawing.Point(318, 20);
            this.LabelTitreFOrm.Name = "LabelTitreFOrm";
            this.LabelTitreFOrm.Size = new System.Drawing.Size(467, 31);
            this.LabelTitreFOrm.TabIndex = 8;
            this.LabelTitreFOrm.Text = "Affichage et exportation des differents Groupes";
            // 
            // DataGridViewEnfant
            // 
            this.DataGridViewEnfant.AllowUserToAddRows = false;
            this.DataGridViewEnfant.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataGridViewEnfant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEnfant.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DataGridViewEnfant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnfant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewEnfant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEnfant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDossier,
            this.Nom,
            this.Prenom,
            this.DateNaissance,
            this.NomBus,
            this.NumGroupe});
            this.DataGridViewEnfant.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.DataGridViewEnfant.Location = new System.Drawing.Point(33, 73);
            this.DataGridViewEnfant.Name = "DataGridViewEnfant";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnfant.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewEnfant.Size = new System.Drawing.Size(656, 527);
            this.DataGridViewEnfant.TabIndex = 9;
            // 
            // NumDossier
            // 
            this.NumDossier.HeaderText = "Numero de Dossier";
            this.NumDossier.Name = "NumDossier";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "Date de Naissance";
            this.DateNaissance.Name = "DateNaissance";
            // 
            // NomBus
            // 
            this.NomBus.HeaderText = "Nom du  Bus";
            this.NomBus.Name = "NomBus";
            // 
            // NumGroupe
            // 
            this.NumGroupe.HeaderText = "Nom du Groupe";
            this.NumGroupe.Name = "NumGroupe";
            // 
            // FrmGestionEffectif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AGE.Properties.Resources.Color1;
            this.ClientSize = new System.Drawing.Size(1064, 621);
            this.Controls.Add(this.DataGridViewEnfant);
            this.Controls.Add(this.LabelTitreFOrm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelGroupeSelect);
            this.Controls.Add(this.ButtonBusOk);
            this.Controls.Add(this.ButtonGroupeOk);
            this.Controls.Add(this.ButtonExportGroupe);
            this.Controls.Add(this.ComboBoxBus);
            this.Controls.Add(this.ComboBoxGroupe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionEffectif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des effectifs ";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnfant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxGroupe;
        private System.Windows.Forms.ComboBox ComboBoxBus;
        private System.Windows.Forms.Button ButtonExportGroupe;
        private System.Windows.Forms.Button ButtonGroupeOk;
        private System.Windows.Forms.Button ButtonBusOk;
        private System.Windows.Forms.Label LabelGroupeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTitreFOrm;
        private System.Windows.Forms.DataGridView DataGridViewEnfant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDossier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGroupe;
    }
}