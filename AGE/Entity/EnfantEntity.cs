using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Entity
{
    internal class EnfantEntity
    {
        public SqlConnection MyConnecion = new SqlConnection("Data Source=DESKTOP-P2GM80O\\SQLEXPRESS01;Initial Catalog=GestioEnfant;Integrated Security=True");
        public string RequetteSQl;
        

        public void GetListEnfant(DataGridView DataGridBoxEnfant)
        {
            RequetteSQl = "Select NumDossier,Nom,Prenom,DateNaissance,G.LibeleGroup ,B.LibeleBus From Membre M join Groupe G ON M.IGroupe = G.IdGroupe join Bus B ON M.IGroupe = B.IdBus";
            
            

            try
            {
                SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    DataGridBoxEnfant.Rows.Add(MyDataReader.GetValue(0).ToString(), MyDataReader.GetValue(1).ToString(), MyDataReader.GetValue(2).ToString(), MyDataReader.GetValue(3).ToString(), MyDataReader.GetValue(4).ToString(), MyDataReader.GetValue(5).ToString());
                }

            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {
                    MyConnecion.Close();
                }
            }
        }

        public void GetListEnfantSup(ComboBox ComboBoxEnfantSuprimer)
        {
            RequetteSQl = "Select NumDossier,Nom,Prenom,DateNaissance,G.LibeleGroup ,B.LibeleBus From Membre M join Groupe G ON M.IGroupe = G.IdGroupe join Bus B ON M.IGroupe = B.IdBus";



            try
            {
                SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    ComboBoxEnfantSuprimer.Items.Add(MyDataReader.GetString(0)+("   ")+MyDataReader.GetString(1)+ ("   ")+MyDataReader.GetString(2));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {
                    MyConnecion.Close();
                }
            }
        }


        public void AddEnfant(string NumDossier,string Nom,string Prenom,string DateNaissance, string IdGroupe , string IdBus)
        {
            RequetteSQl = $"INSERT INTO Membre(NumDossier, Nom, Prenom, DateNaissance, IdBus, IGroupe) values('{NumDossier}','{Nom}','{Prenom}','{DateNaissance}',{IdGroupe},{IdBus});";
         

            try
            {
                SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {
                    
                    MyConnecion.Close();
                    MessageBox.Show("L'enfant a bien été ajouter ","Succes de l'ajout",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        public void DeletEnfant(string ID)
        {
            RequetteSQl = $"DELETE From dbo.Membre WHERE  Id =  {ID} ";


            try
            {
                SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MyConnecion.State == ConnectionState.Open)
                {

                    MyConnecion.Close();
                    MessageBox.Show("L'enfant a bien été Supprimer ", "Succes de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
