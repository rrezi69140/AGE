using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Entity
{
    internal class GroupeEntity
    {
        public SqlConnection MyConnecion = new SqlConnection("Data Source=DESKTOP-1K0GE9A\\SQLEXPRESS;Initial Catalog=GestioEnfant;Integrated Security=True");
        public string RequetteSQl;

        public void GetListGroupe(ComboBox ComboBoxGroupe)
        {
            RequetteSQl = "Select LibeleGroup  From Groupe";
            SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
            

            try
            {
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    ComboBoxGroupe.Items.Add(MyDataReader.GetString(0));
                }

            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {
                    MyConnecion.Close();
                }
            }
        }
         public void GetListEnfantGroupe(ComboBox ComboBoxGroupe,DataGridView dataGridView, ref List<string> RefListEnfant) 
        {

            
           
            string GroupeSelectionner;
            GroupeSelectionner = ComboBoxGroupe.SelectedItem.ToString();
            RefListEnfant.Clear();
            
            
            RequetteSQl = $"Select NumDossier,Nom,Prenom,DateNaissance,G.LibeleGroup ,B.LibeleBus From Membre M join Groupe G ON M.IGroupe = G.IdGroupe join Bus B ON M.IGroupe = B.IdBus where G.LibeleGroup = '{GroupeSelectionner}'";
            SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
            try
            {
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                dataGridView.Rows.Clear();
                while (MyDataReader.Read())
                {
                    
                    dataGridView.Rows.Add(MyDataReader.GetValue(0).ToString(), MyDataReader.GetValue(1).ToString(), MyDataReader.GetValue(2).ToString(), MyDataReader.GetValue(3).ToString(), MyDataReader.GetValue(4).ToString(), MyDataReader.GetValue(5).ToString());
                    string NumDossier = ($"{MyDataReader.GetValue(0)};");
                    string Nom = ($"{MyDataReader.GetValue(1)};");
                    string Prenom =($"{MyDataReader.GetValue(2)};");
                    string DateNaissance = ($"{MyDataReader.GetValue(3)};");
                    string Groupe =($"{MyDataReader.GetValue(4)};");
                    string Bus = ($"{MyDataReader.GetValue(5)}");
                    string Ligne = (NumDossier+Nom+Prenom+DateNaissance+Groupe+Bus);
                    RefListEnfant.Add( Ligne );

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {
                    MyConnecion.Close();
                }
            }


        }
       
    }
}
