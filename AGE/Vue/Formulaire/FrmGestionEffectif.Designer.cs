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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEffectif));
            this.ComboBoxGroupe = new System.Windows.Forms.ComboBox();
            this.ComboBoxBus = new System.Windows.Forms.ComboBox();
            this.ButtonExport = new System.Windows.Forms.Button();
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
            this.NumBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(848, 272);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(75, 23);
            this.ButtonExport.TabIndex = 3;
            this.ButtonExport.Text = "Exporter";
            this.ButtonExport.UseVisualStyleBackColor = true;
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
            this.LabelGroupeSelect.Location = new System.Drawing.Point(743, 90);
            this.LabelGroupeSelect.Name = "LabelGroupeSelect";
            this.LabelGroupeSelect.Size = new System.Drawing.Size(156, 13);
            this.LabelGroupeSelect.TabIndex = 6;
            this.LabelGroupeSelect.Text = "Afficher le groupe selectionner :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Afficher le Bus selectionner :";
            // 
            // LabelTitreFOrm
            // 
            this.LabelTitreFOrm.AutoSize = true;
            this.LabelTitreFOrm.Location = new System.Drawing.Point(300, 24);
            this.LabelTitreFOrm.Name = "LabelTitreFOrm";
            this.LabelTitreFOrm.Size = new System.Drawing.Size(228, 13);
            this.LabelTitreFOrm.TabIndex = 8;
            this.LabelTitreFOrm.Text = "Affichage et exportation des differents Groupes";
            // 
            // DataGridViewEnfant
            // 
            this.DataGridViewEnfant.AllowUserToAddRows = false;
            this.DataGridViewEnfant.AllowUserToDeleteRows = false;
            this.DataGridViewEnfant.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEnfant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnfant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEnfant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEnfant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDossier,
            this.Nom,
            this.Prenom,
            this.DateNaissance,
            this.NumBus,
            this.NumGroupe});
            this.DataGridViewEnfant.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridViewEnfant.Location = new System.Drawing.Point(33, 82);
            this.DataGridViewEnfant.Name = "DataGridViewEnfant";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnfant.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewEnfant.Size = new System.Drawing.Size(656, 468);
            this.DataGridViewEnfant.TabIndex = 9;
            // 
            // NumDossier
            // 
            this.NumDossier.HeaderText = "NumeroDossier";
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
            this.DateNaissance.HeaderText = "DateNaissance";
            this.DateNaissance.Name = "DateNaissance";
            // 
            // NumBus
            // 
            this.NumBus.HeaderText = "NumBus";
            this.NumBus.Name = "NumBus";
            // 
            // NumGroupe
            // 
            this.NumGroupe.HeaderText = "NumGroupe";
            this.NumGroupe.Name = "NumGroupe";
            // 
            // FrmGestionEffectif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 621);
            this.Controls.Add(this.DataGridViewEnfant);
            this.Controls.Add(this.LabelTitreFOrm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelGroupeSelect);
            this.Controls.Add(this.ButtonBusOk);
            this.Controls.Add(this.ButtonGroupeOk);
            this.Controls.Add(this.ButtonExport);
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
        private System.Windows.Forms.Button ButtonExport;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGroupe;
    }
}