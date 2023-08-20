using AGE.Vue.Formulaire.Effectif;
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
    public partial class FrmGestionEffectif : Form
    {
        public FrmGestionEffectif()
        {
            InitializeComponent();
        }
        FrmAjouterEnfant FormulaireAjoutEnfant = new FrmAjouterEnfant();
        FrmModiferEnfant FormulaireModifierEnfant = new FrmModiferEnfant();
        FrmSupprimerEnfant FormulaireSupprimerEnfant = new FrmSupprimerEnfant();
        private void ButtonAddEffectif_Click(object sender, EventArgs e)
        {
            FormulaireAjoutEnfant.Show();
        }

        private void ButtonDeletEffectif_Click(object sender, EventArgs e)
        {
            FormulaireSupprimerEnfant.Show();
        }

        private void ButtonModifyEffectif_Click(object sender, EventArgs e)
        {
            FormulaireModifierEnfant.Show();
        }
    }
}
