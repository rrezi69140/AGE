using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Vue.Formulaire.Aceuille
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }
        private int timerLeft;
       FrmAceuilleLancementAplication FormulaireAceuille = new FrmAceuilleLancementAplication();


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerLeft < 10)
            {
                timerLeft = timerLeft - 1;
            }
            else
            {
                SplashTimer.Stop();
                FormulaireAceuille.Show();
                this.Hide();
            }
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timerLeft = 10;
            SplashTimer.Start();

        }
    }
}
