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

namespace AGE.Vue.Formulaire.Liste
{
    public partial class FrmModifierListe : Form
    {
        public FrmModifierListe()
        {
            InitializeComponent();
        }
        ListeEntity Liste = new ListeEntity();
        List<int> ListListeIndexSelectionner = new List<int>();

        private void ButtonAnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModifierListe_Load(object sender, EventArgs e)
        {
            Liste.GetListListe(ComboLIsteAModifier);
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            int index = ComboLIsteAModifier.SelectedIndex;
            int ListeSelectionner = ListListeIndexSelectionner[index];


            Liste.ModifyList(ListeSelectionner.ToString(), TextBoxNomListe.Text.ToString());
        }
    }
}
