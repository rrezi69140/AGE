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
        public FrmAjouterEnfant()
        {
            InitializeComponent();
        }

        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
