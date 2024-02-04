using AGE.Entity;
using System;
using System.Windows.Forms;

namespace AGE.Vue.Formulaire.Liste
{
    public partial class FrmNouvelleListe : Form
    {
        public FrmNouvelleListe()
        {
            InitializeComponent();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BouttonValider_Click(object sender, EventArgs e)
        {
            ListeEntity listeEntity = new ListeEntity();
            listeEntity.AddListe(TextBoxAjouterListe.Text.ToString());
        }
    }
}
