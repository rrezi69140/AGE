﻿namespace AGE.Vue.Formulaire
{
    partial class FrmAceuilleLancementAplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEffectifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesListesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exploitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioEnfantDataSet1 = new AGE.GestioEnfantDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestioEnfantDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.exploitationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEffectifsToolStripMenuItem,
            this.gestionDesListesToolStripMenuItem1});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionToolStripMenuItem.Image = global::AGE.Properties.Resources.Gestion;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(117, 35);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesEffectifsToolStripMenuItem
            // 
            this.gestionDesEffectifsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesEffectifsToolStripMenuItem.Image = global::AGE.Properties.Resources.gestioneffectif;
            this.gestionDesEffectifsToolStripMenuItem.Name = "gestionDesEffectifsToolStripMenuItem";
            this.gestionDesEffectifsToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.gestionDesEffectifsToolStripMenuItem.Text = "Gestion des Effectifs";
            this.gestionDesEffectifsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEffectifsToolStripMenuItem_Click);
            // 
            // gestionDesListesToolStripMenuItem1
            // 
            this.gestionDesListesToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesListesToolStripMenuItem1.Image = global::AGE.Properties.Resources.GestionListe;
            this.gestionDesListesToolStripMenuItem1.Name = "gestionDesListesToolStripMenuItem1";
            this.gestionDesListesToolStripMenuItem1.Size = new System.Drawing.Size(221, 28);
            this.gestionDesListesToolStripMenuItem1.Text = "Gestion des Listes";
            this.gestionDesListesToolStripMenuItem1.Click += new System.EventHandler(this.gestionDesListesToolStripMenuItem1_Click);
            // 
            // exploitationToolStripMenuItem
            // 
            this.exploitationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherListeToolStripMenuItem});
            this.exploitationToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exploitationToolStripMenuItem.Image = global::AGE.Properties.Resources.Exploitation;
            this.exploitationToolStripMenuItem.Name = "exploitationToolStripMenuItem";
            this.exploitationToolStripMenuItem.Size = new System.Drawing.Size(155, 35);
            this.exploitationToolStripMenuItem.Text = "Exploitation";
            // 
            // afficherListeToolStripMenuItem
            // 
            this.afficherListeToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherListeToolStripMenuItem.Image = global::AGE.Properties.Resources.AfficherList;
            this.afficherListeToolStripMenuItem.Name = "afficherListeToolStripMenuItem";
            this.afficherListeToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.afficherListeToolStripMenuItem.Text = "Afficher Liste";
            this.afficherListeToolStripMenuItem.Click += new System.EventHandler(this.afficherListeToolStripMenuItem_Click);
            // 
            // gestioEnfantDataSet1
            // 
            this.gestioEnfantDataSet1.DataSetName = "GestioEnfantDataSet";
            this.gestioEnfantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmAceuilleLancementAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAceuilleLancementAplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAceuilleLancementAplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestioEnfantDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEffectifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesListesToolStripMenuItem1;
        private GestioEnfantDataSet gestioEnfantDataSet1;
        private System.Windows.Forms.ToolStripMenuItem exploitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherListeToolStripMenuItem;
    }
}