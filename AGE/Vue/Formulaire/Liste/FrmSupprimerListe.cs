﻿using System;
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

        private void ButtonAnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
