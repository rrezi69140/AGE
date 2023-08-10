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

namespace AGE.Vue.Formulaire
{
    public partial class FrmGestionEffectif : Form
    {
        public FrmGestionEffectif()
        {
            InitializeComponent();
            EnfantEntity Enfant = new EnfantEntity();
            BusEntity Bus = new BusEntity();
            GroupeEntity Groupe = new GroupeEntity();

            Enfant.GetListEnfant(DataGridViewEnfant);
            Bus.GetListBus(ComboBoxBus);
            Groupe.GetListGroupe(ComboBoxGroupe);
            

        }
        

        private void ButtonGroupeOk_Click(object sender, EventArgs e)
        {
            GroupeEntity Groupe = new GroupeEntity();
            Groupe.GetListEnfantGroupe(ComboBoxGroupe, DataGridViewEnfant);
            

        }

        private void ButtonBusOk_Click(object sender, EventArgs e)
        {
            BusEntity Bus= new BusEntity();
            Bus.GetListEnfantBus(ComboBoxBus, DataGridViewEnfant);

        }
    }
    
}
