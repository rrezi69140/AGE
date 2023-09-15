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
    public partial class FrmModiferEnfant : Form
    {
        public FrmModiferEnfant()
        {
            InitializeComponent();
        }
        BusEntity Bus = new BusEntity();
        GroupeEntity Groupe = new GroupeEntity();
        EnfantEntity Enfant = new EnfantEntity();
        List<int> ListIndexSelectionner = new List<int>();

        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModiferEnfant_Load(object sender, EventArgs e)
        {
            Bus.GetListBus(ComboBoxBus);
            Groupe.GetListGroupe(ComboBoxGroupe);
            Enfant.GetListEnfantMod(ComboBoxEnfantAModifier,ref ListIndexSelectionner);
        }

        private void ComboBoxEnfantAModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ComboBoxEnfantAModifier.SelectedIndex;
            int membreSelectionner = ListIndexSelectionner[index];
            Enfant.PreRemplissageComboBox(TextBoxNumDossier, TextBoxNom, TextBoxPrenom, DateTimePIckerDateNaissance, ComboBoxBus, ComboBoxGroupe, membreSelectionner );

        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            int index = ComboBoxEnfantAModifier.SelectedIndex;
            int membreSelectionner = ListIndexSelectionner[index];
            Enfant.ModifyEnfant(membreSelectionner.ToString(),TextBoxNumDossier.Text, TextBoxNom.Text, TextBoxPrenom.Text, DateTimePIckerDateNaissance.Value.ToString(), ComboBoxGroupe.SelectedIndex.ToString(),ComboBoxBus.SelectedIndex.ToString() );
        }
    }
}
