namespace AGE.Vue.Formulaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAceuilleLancementAplication));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AffichageDesListesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEffectifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesListesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gestionToolStripMenuItem.BackgroundImage")));
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AffichageDesListesToolStripMenuItem,
            this.gestionDesEffectifsToolStripMenuItem,
            this.gestionDesListesToolStripMenuItem1});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // AffichageDesListesToolStripMenuItem
            // 
            this.AffichageDesListesToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AffichageDesListesToolStripMenuItem.BackgroundImage")));
            this.AffichageDesListesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffichageDesListesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.AffichageDesListesToolStripMenuItem.Image = global::AGE.Properties.Resources.liste_de_controle;
            this.AffichageDesListesToolStripMenuItem.Name = "AffichageDesListesToolStripMenuItem";
            this.AffichageDesListesToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.AffichageDesListesToolStripMenuItem.Text = "Afficher les Liste";
            this.AffichageDesListesToolStripMenuItem.Click += new System.EventHandler(this.AffichageDesListesToolStripMenuItem_Click);
            // 
            // gestionDesEffectifsToolStripMenuItem
            // 
            this.gestionDesEffectifsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesEffectifsToolStripMenuItem.Image = global::AGE.Properties.Resources.person_circle_plus_solid;
            this.gestionDesEffectifsToolStripMenuItem.Name = "gestionDesEffectifsToolStripMenuItem";
            this.gestionDesEffectifsToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.gestionDesEffectifsToolStripMenuItem.Text = "Gestion des Effectifs";
            this.gestionDesEffectifsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEffectifsToolStripMenuItem_Click);
            // 
            // gestionDesListesToolStripMenuItem1
            // 
            this.gestionDesListesToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesListesToolStripMenuItem1.Name = "gestionDesListesToolStripMenuItem1";
            this.gestionDesListesToolStripMenuItem1.Size = new System.Drawing.Size(221, 28);
            this.gestionDesListesToolStripMenuItem1.Text = "Gestion des Listes";
            this.gestionDesListesToolStripMenuItem1.Click += new System.EventHandler(this.gestionDesListesToolStripMenuItem1_Click);
            // 
            // FrmAceuilleLancementAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAceuilleLancementAplication";
            this.Text = "FrmAceuilleLancementAplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AffichageDesListesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEffectifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesListesToolStripMenuItem1;
    }
}