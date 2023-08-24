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
    public partial class FrmAjouterEnfant : Form
    {
        EnfantEntity Enfant = new EnfantEntity();
        public FrmAjouterEnfant()
        {
            InitializeComponent();
        }

        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Enfant.AddEnfant(TextBoxNumDossier.Text, TextBoxNom.Text, TextBoxPrenom.Text, TextBoxDateNaissance.Text, ComboBoxSelectionGroupe.Text, ComboBoxSelectionBus.Text);
        }
    }
}
