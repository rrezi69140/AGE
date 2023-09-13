using AGE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Vue.Formulaire.Effectif
{
    public partial class FrmSupprimerEnfant : Form
    {

        public FrmSupprimerEnfant()
        {
            InitializeComponent();
        }
        EnfantEntity Enfant = new EnfantEntity();
        int EnfantSelectioner;
        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BouttonValider_Click(object sender, EventArgs e)
        {
            EnfantSelectioner = (ComboBoxEnfantASuprimmer.SelectedIndex + 1);
            Enfant.DeletEnfant(EnfantSelectioner.ToString());

        }

        private void FrmSupprimerEnfant_Load(object sender, EventArgs e)
        {
            Enfant.GetListEnfantSup(ComboBoxEnfantASuprimmer);

        }
    }
}
