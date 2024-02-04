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
    public partial class FrmSupprimerListe : Form
    {
        public FrmSupprimerListe()
        {
            InitializeComponent();
        
        }
        int ListeSelectionner;
        ListeEntity Liste = new ListeEntity();

        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BouttonValider_Click(object sender, EventArgs e)
        {
            
            ListeSelectionner = (ComboBoxListeASuprimmer.SelectedIndex + 1);
            Liste.DeletListe(ListeSelectionner.ToString());
        }

        private void FrmSupprimerListe_Load(object sender, EventArgs e)
        {
            Liste.GetListListe(ComboBoxListeASuprimmer);
        }
    }
}
