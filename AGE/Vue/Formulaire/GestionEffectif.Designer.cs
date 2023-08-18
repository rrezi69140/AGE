namespace AGE.Vue.Formulaire
{
    partial class GestionEffectif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEffectif));
            this.ButtonAddEffectif = new System.Windows.Forms.Button();
            this.ButtonDeletEffectif = new System.Windows.Forms.Button();
            this.ButtonModifyEffectif = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAddEffectif
            // 
            this.ButtonAddEffectif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddEffectif.Image = global::AGE.Properties.Resources.AddPersonne;
            this.ButtonAddEffectif.Location = new System.Drawing.Point(211, 154);
            this.ButtonAddEffectif.Name = "ButtonAddEffectif";
            this.ButtonAddEffectif.Size = new System.Drawing.Size(55, 55);
            this.ButtonAddEffectif.TabIndex = 3;
            this.ButtonAddEffectif.UseVisualStyleBackColor = true;
            // 
            // ButtonDeletEffectif
            // 
            this.ButtonDeletEffectif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeletEffectif.Image = global::AGE.Properties.Resources.DeletPersonne;
            this.ButtonDeletEffectif.Location = new System.Drawing.Point(211, 259);
            this.ButtonDeletEffectif.Name = "ButtonDeletEffectif";
            this.ButtonDeletEffectif.Size = new System.Drawing.Size(55, 55);
            this.ButtonDeletEffectif.TabIndex = 2;
            this.ButtonDeletEffectif.UseVisualStyleBackColor = true;
            // 
            // ButtonModifyEffectif
            // 
            this.ButtonModifyEffectif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModifyEffectif.Image = global::AGE.Properties.Resources.modifyPerson;
            this.ButtonModifyEffectif.Location = new System.Drawing.Point(211, 371);
            this.ButtonModifyEffectif.Name = "ButtonModifyEffectif";
            this.ButtonModifyEffectif.Size = new System.Drawing.Size(55, 55);
            this.ButtonModifyEffectif.TabIndex = 1;
            this.ButtonModifyEffectif.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajouter un Enfant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modifier un Enfant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suprimer un Enfant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liste Selectioné :";
            // 
            // GestionEffectif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButtonAddEffectif);
            this.Controls.Add(this.ButtonDeletEffectif);
            this.Controls.Add(this.ButtonModifyEffectif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionEffectif";
            this.Text = "GestionEffectif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonModifyEffectif;
        private System.Windows.Forms.Button ButtonDeletEffectif;
        private System.Windows.Forms.Button ButtonAddEffectif;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}