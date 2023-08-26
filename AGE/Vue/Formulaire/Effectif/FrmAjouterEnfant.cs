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
        BusEntity Bus = new BusEntity();
        GroupeEntity Groupe = new GroupeEntity();
        int BusSelectionner;
        int GroupeSelectioner;
        
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
            GroupeSelectioner = (ComboBoxSelectionGroupe.SelectedIndex)+1;
            BusSelectionner = (ComboBoxSelectionBus.SelectedIndex)+1;
            Enfant.AddEnfant(TextBoxNumDossier.Text, TextBoxNom.Text, TextBoxPrenom.Text, DateTimePicker.Value.ToString(), GroupeSelectioner.ToString(), BusSelectionner.ToString() );
        }

        private void FrmAjouterEnfant_Load(object sender, EventArgs e)
        {
            Bus.GetListBus(ComboBoxSelectionBus);
            Groupe.GetListGroupe(ComboBoxSelectionGroupe);
        }
    }
}
