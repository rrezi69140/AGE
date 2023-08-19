using AGE.Vue.Formulaire.Liste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Vue.Formulaire
{
    public partial class FrmGestionListe : Form
    {
        public FrmGestionListe()
        {
            InitializeComponent();
        }
         public FrmNouvelleListe FormulaireCreationListe = new FrmNouvelleListe();
        public FrmModifierListe FormulaireModifierListe = new FrmModifierListe();
        public FrmSupprimerListe FrmSupprimerListe = new FrmSupprimerListe();

        

        private void ButtonAjouterListe_Click(object sender, EventArgs e)
        {
            FormulaireCreationListe.Show();
        }

        private void ButtonModiferListe_Click(object sender, EventArgs e)
        {
            FormulaireModifierListe.Show();
        }

        private void ButtonSuprimmerListe_Click(object sender, EventArgs e)
        {
            FrmSupprimerListe.Show();
        }
    }
}
