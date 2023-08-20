using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AGE.Vue.Formulaire.Aceuille
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }
       
       FrmAceuilleLancementAplication FormulaireAceuille = new FrmAceuilleLancementAplication();



        private void SplashScreen_Load(object sender, EventArgs e)
        {
           
            SplashTimer.Start();
            ProgresseBare.Value = 0;
            ProgresseBare.Maximum = 500;
            ProgresseBare.ForeColor = Color.Blue;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            ProgresseBare.Value += 100;
           
            
            
            if (ProgresseBare.Value > 499)
            {
                SplashTimer.Stop();
                FormulaireAceuille.Show();
                this.Hide();
            }
            
        }

      
    }
}
