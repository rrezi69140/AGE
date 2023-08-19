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
    public partial class FrmAceuilleLancementAplication : Form
    {
        public FrmAceuilleLancementAplication()
        {
            InitializeComponent();
        }
        public FrmAfficherListe FormulaireGestionListe = new FrmAfficherListe();

        private void gestionDesListesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireGestionListe.Show();
        
        }
    }
}
