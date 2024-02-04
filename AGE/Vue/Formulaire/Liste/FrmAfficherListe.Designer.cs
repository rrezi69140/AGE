namespace AGE.Vue.Formulaire
{
    partial class FrmAfficherListe
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
            System.Windows.Forms.Button ButtonGroupeOk;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfficherListe));
            this.ComboBoxGroupe = new System.Windows.Forms.ComboBox();
            this.ComboBoxBus = new System.Windows.Forms.ComboBox();
            this.ButtonExportGroupe = new System.Windows.Forms.Button();
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
            this.NomListe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxListerListe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonOKListerList = new System.Windows.Forms.Button();
            ButtonGroupeOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnfant)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGroupeOk
            // 
            ButtonGroupeOk.BackColor = System.Drawing.Color.Transparent;
            ButtonGroupeOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ButtonGroupeOk.Image = global::AGE.Properties.Resources.square_check_solid;
            ButtonGroupeOk.Location = new System.Drawing.Point(1268, 171);
            ButtonGroupeOk.Margin = new System.Windows.Forms.Padding(4);
            ButtonGroupeOk.Name = "ButtonGroupeOk";
            ButtonGroupeOk.Size = new System.Drawing.Size(53, 37);
            ButtonGroupeOk.TabIndex = 4;
            ButtonGroupeOk.UseVisualStyleBackColor = false;
            ButtonGroupeOk.Click += new System.EventHandler(this.ButtonGroupeOk_Click);
            // 
            // ComboBoxGroupe
            // 
            this.ComboBoxGroupe.DropDownHeight = 150;
            this.ComboBoxGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroupe.DropDownWidth = 160;
            this.ComboBoxGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGroupe.FormattingEnabled = true;
            this.ComboBoxGroupe.IntegralHeight = false;
            this.ComboBoxGroupe.Location = new System.Drawing.Point(1016, 171);
            this.ComboBoxGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxGroupe.Name = "ComboBoxGroupe";
            this.ComboBoxGroupe.Size = new System.Drawing.Size(212, 37);
            this.ComboBoxGroupe.TabIndex = 1;
            // 
            // ComboBoxBus
            // 
            this.ComboBoxBus.DropDownHeight = 150;
            this.ComboBoxBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBus.FormattingEnabled = true;
            this.ComboBoxBus.IntegralHeight = false;
            this.ComboBoxBus.ItemHeight = 29;
            this.ComboBoxBus.Location = new System.Drawing.Point(1016, 312);
            this.ComboBoxBus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxBus.Name = "ComboBoxBus";
            this.ComboBoxBus.Size = new System.Drawing.Size(212, 37);
            this.ComboBoxBus.TabIndex = 2;
            // 
            // ButtonExportGroupe
            // 
            this.ButtonExportGroupe.Image = global::AGE.Properties.Resources.exportUntitled;
            this.ButtonExportGroupe.Location = new System.Drawing.Point(1027, 535);
            this.ButtonExportGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExportGroupe.Name = "ButtonExportGroupe";
            this.ButtonExportGroupe.Size = new System.Drawing.Size(189, 62);
            this.ButtonExportGroupe.TabIndex = 3;
            this.ButtonExportGroupe.UseVisualStyleBackColor = true;
            this.ButtonExportGroupe.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonBusOk
            // 
            this.ButtonBusOk.Image = global::AGE.Properties.Resources.square_check_solid;
            this.ButtonBusOk.Location = new System.Drawing.Point(1268, 312);
            this.ButtonBusOk.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBusOk.Name = "ButtonBusOk";
            this.ButtonBusOk.Size = new System.Drawing.Size(53, 37);
            this.ButtonBusOk.TabIndex = 5;
            this.ButtonBusOk.UseVisualStyleBackColor = true;
            this.ButtonBusOk.Click += new System.EventHandler(this.ButtonBusOk_Click);
            // 
            // LabelGroupeSelect
            // 
            this.LabelGroupeSelect.AutoSize = true;
            this.LabelGroupeSelect.BackColor = System.Drawing.Color.Transparent;
            this.LabelGroupeSelect.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupeSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.LabelGroupeSelect.Location = new System.Drawing.Point(979, 107);
            this.LabelGroupeSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGroupeSelect.Name = "LabelGroupeSelect";
            this.LabelGroupeSelect.Size = new System.Drawing.Size(312, 37);
            this.LabelGroupeSelect.TabIndex = 6;
            this.LabelGroupeSelect.Text = "Trier la liste par Groupe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(998, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trier la liste par Bus:";
            // 
            // LabelTitreFOrm
            // 
            this.LabelTitreFOrm.AutoSize = true;
            this.LabelTitreFOrm.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitreFOrm.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitreFOrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.LabelTitreFOrm.Location = new System.Drawing.Point(328, 11);
            this.LabelTitreFOrm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitreFOrm.Name = "LabelTitreFOrm";
            this.LabelTitreFOrm.Size = new System.Drawing.Size(672, 41);
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
            this.DataGridViewEnfant.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEnfant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.NumGroupe,
            this.NomListe});
            this.DataGridViewEnfant.GridColor = System.Drawing.Color.White;
            this.DataGridViewEnfant.Location = new System.Drawing.Point(44, 90);
            this.DataGridViewEnfant.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewEnfant.Name = "DataGridViewEnfant";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnfant.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewEnfant.RowHeadersWidth = 51;
            this.DataGridViewEnfant.Size = new System.Drawing.Size(875, 649);
            this.DataGridViewEnfant.TabIndex = 9;
            // 
            // NumDossier
            // 
            this.NumDossier.HeaderText = "Numero de Dossier";
            this.NumDossier.MinimumWidth = 6;
            this.NumDossier.Name = "NumDossier";
            this.NumDossier.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 125;
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "Date de Naissance";
            this.DateNaissance.MinimumWidth = 6;
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Width = 125;
            // 
            // NomBus
            // 
            this.NomBus.HeaderText = "Nom du  Bus";
            this.NomBus.MinimumWidth = 6;
            this.NomBus.Name = "NomBus";
            this.NomBus.Width = 125;
            // 
            // NumGroupe
            // 
            this.NumGroupe.HeaderText = "Nom du Groupe";
            this.NumGroupe.MinimumWidth = 6;
            this.NumGroupe.Name = "NumGroupe";
            this.NumGroupe.Width = 125;
            // 
            // NomListe
            // 
            this.NomListe.HeaderText = "NomListe";
            this.NomListe.MinimumWidth = 6;
            this.NomListe.Name = "NomListe";
            this.NomListe.Width = 125;
            // 
            // ComboBoxListerListe
            // 
            this.ComboBoxListerListe.DropDownHeight = 150;
            this.ComboBoxListerListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxListerListe.DropDownWidth = 160;
            this.ComboBoxListerListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxListerListe.FormattingEnabled = true;
            this.ComboBoxListerListe.IntegralHeight = false;
            this.ComboBoxListerListe.Location = new System.Drawing.Point(1016, 474);
            this.ComboBoxListerListe.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxListerListe.Name = "ComboBoxListerListe";
            this.ComboBoxListerListe.Size = new System.Drawing.Size(212, 37);
            this.ComboBoxListerListe.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(950, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trier la liste par liste";
            // 
            // ButtonOKListerList
            // 
            this.ButtonOKListerList.Image = global::AGE.Properties.Resources.square_check_solid;
            this.ButtonOKListerList.Location = new System.Drawing.Point(1268, 477);
            this.ButtonOKListerList.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOKListerList.Name = "ButtonOKListerList";
            this.ButtonOKListerList.Size = new System.Drawing.Size(53, 37);
            this.ButtonOKListerList.TabIndex = 12;
            this.ButtonOKListerList.UseVisualStyleBackColor = true;
            this.ButtonOKListerList.Click += new System.EventHandler(this.ButtonOKListerList_Click);
            // 
            // FrmAfficherListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1419, 764);
            this.Controls.Add(this.ButtonOKListerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxListerListe);
            this.Controls.Add(this.DataGridViewEnfant);
            this.Controls.Add(this.LabelTitreFOrm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelGroupeSelect);
            this.Controls.Add(this.ButtonBusOk);
            this.Controls.Add(ButtonGroupeOk);
            this.Controls.Add(this.ButtonExportGroupe);
            this.Controls.Add(this.ComboBoxBus);
            this.Controls.Add(this.ComboBoxGroupe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAfficherListe";
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
        private System.Windows.Forms.Button ButtonBusOk;
        private System.Windows.Forms.Label LabelGroupeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTitreFOrm;
        private System.Windows.Forms.DataGridView DataGridViewEnfant;
        private System.Windows.Forms.ComboBox ComboBoxListerListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonOKListerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDossier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomListe;
    }
}