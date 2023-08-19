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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;





namespace AGE.Vue.Formulaire
{
    public partial class FrmAfficherListe : Form
    {
        public FrmAfficherListe()
        {
            InitializeComponent();
            EnfantEntity Enfant = new EnfantEntity();
            BusEntity Bus = new BusEntity();
            GroupeEntity Groupe = new GroupeEntity();

           
            

            Enfant.GetListEnfant(DataGridViewEnfant);
            Bus.GetListBus(ComboBoxBus);
            Groupe.GetListGroupe(ComboBoxGroupe);
        }

        List<string> ListEnfant = new List<string>();

        private void ButtonGroupeOk_Click(object sender, EventArgs e)
        {
            GroupeEntity Groupe = new GroupeEntity();
           
            Groupe.GetListEnfantGroupe(ComboBoxGroupe, DataGridViewEnfant, ref ListEnfant);

           


        }

        private void ButtonBusOk_Click(object sender, EventArgs e)
        {
            BusEntity Bus= new BusEntity();
            Bus.GetListEnfantBus(ComboBoxBus, DataGridViewEnfant, ref ListEnfant);

        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.Title = "Exporter la liste";
                SaveFile.AddExtension = true;
             
                SaveFile.ShowDialog();

                if (SaveFile.FileName != "")

                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter StreamFileWriter = new StreamWriter(SaveFile.FileName);

                        StreamFileWriter.WriteLine("Numeros de dossier;Nom;Prenom;Date de naissance;Groupe;Bus");
                        for (int i = 0; ListEnfant.Count > i; i++)
                        {
                            StreamFileWriter.WriteLine($"{ListEnfant[i]}");
                        }
                        StreamFileWriter.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Le fichier na pas pu être exporter cause : {ex.Message} ps:Veuller contacter rachid ");
            }
            
        }
    }
    
}
