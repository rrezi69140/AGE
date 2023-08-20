using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AGE.Vue.Formulaire
{
    public partial class FrmAceuilleLancementAplication : Form
    {
        public FrmAceuilleLancementAplication()
        {
            InitializeComponent();
        }
        public FrmAfficherListe FormulaireAfficherListe = new FrmAfficherListe();
        public FrmGestionListe FormulaireGestionListe = new FrmGestionListe();
        public FrmGestionEffectif FormulaireGestionEffectif = new FrmGestionEffectif();
        
        private void AffichageDesListesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireAfficherListe.Show();
        
        }

      

        private void gestionDesListesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormulaireGestionListe.Show();
        }

        private void gestionDesEffectifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireGestionEffectif.Show();
        }

        private void afficherListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireAfficherListe.Show();
        }
    }
}
