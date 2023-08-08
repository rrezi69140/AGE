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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEffectif));
            this.ComboBoxGroupe = new System.Windows.Forms.ComboBox();
            this.ComboBoxBus = new System.Windows.Forms.ComboBox();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.ButtonGroupeOk = new System.Windows.Forms.Button();
            this.ButtonBusOk = new System.Windows.Forms.Button();
            this.LabelGroupeSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTitreFOrm = new System.Windows.Forms.Label();
            this.ListBoxEnfant = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComboBoxGroupe
            // 
            this.ComboBoxGroupe.FormattingEnabled = true;
            this.ComboBoxGroupe.Location = new System.Drawing.Point(420, 126);
            this.ComboBoxGroupe.Name = "ComboBoxGroupe";
            this.ComboBoxGroupe.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxGroupe.TabIndex = 1;
            // 
            // ComboBoxBus
            // 
            this.ComboBoxBus.FormattingEnabled = true;
            this.ComboBoxBus.Location = new System.Drawing.Point(420, 207);
            this.ComboBoxBus.Name = "ComboBoxBus";
            this.ComboBoxBus.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBus.TabIndex = 2;
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(420, 394);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(75, 23);
            this.ButtonExport.TabIndex = 3;
            this.ButtonExport.Text = "Exporter";
            this.ButtonExport.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupeOk
            // 
            this.ButtonGroupeOk.Location = new System.Drawing.Point(563, 126);
            this.ButtonGroupeOk.Name = "ButtonGroupeOk";
            this.ButtonGroupeOk.Size = new System.Drawing.Size(34, 23);
            this.ButtonGroupeOk.TabIndex = 4;
            this.ButtonGroupeOk.Text = "OK";
            this.ButtonGroupeOk.UseVisualStyleBackColor = true;
            // 
            // ButtonBusOk
            // 
            this.ButtonBusOk.Location = new System.Drawing.Point(563, 205);
            this.ButtonBusOk.Name = "ButtonBusOk";
            this.ButtonBusOk.Size = new System.Drawing.Size(34, 23);
            this.ButtonBusOk.TabIndex = 5;
            this.ButtonBusOk.Text = "OK";
            this.ButtonBusOk.UseVisualStyleBackColor = true;
            // 
            // LabelGroupeSelect
            // 
            this.LabelGroupeSelect.AutoSize = true;
            this.LabelGroupeSelect.Location = new System.Drawing.Point(417, 94);
            this.LabelGroupeSelect.Name = "LabelGroupeSelect";
            this.LabelGroupeSelect.Size = new System.Drawing.Size(156, 13);
            this.LabelGroupeSelect.TabIndex = 6;
            this.LabelGroupeSelect.Text = "Afficher le groupe selectionner :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 178);
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
            // ListBoxEnfant
            // 
            this.ListBoxEnfant.FormattingEnabled = true;
            this.ListBoxEnfant.Location = new System.Drawing.Point(24, 57);
            this.ListBoxEnfant.Name = "ListBoxEnfant";
            this.ListBoxEnfant.Size = new System.Drawing.Size(355, 381);
            this.ListBoxEnfant.TabIndex = 9;
            // 
            // FrmGestionEffectif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxEnfant);
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
        private System.Windows.Forms.ListBox ListBoxEnfant;
    }
}