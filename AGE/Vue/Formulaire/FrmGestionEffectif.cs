﻿using AGE.Entity;
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

            Enfant.GetListEnfant(DataGridViewEnfant);
            Bus.GetListBus(ComboBoxBus);

        }
        

       
       
    }
    
}
