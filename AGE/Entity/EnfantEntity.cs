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
    internal class EnfantEntity
    {
        public SqlConnection MyConnecion = new SqlConnection("Data Source=DESKTOP-1K0GE9A\\SQLEXPRESS;Initial Catalog=GestioEnfant;Integrated Security=True");
        public string RequetteSQl;

        public void GetListEnfant(ListBox ListeBoxEnfant)
        {
            RequetteSQl = "Select * From Membre";
            SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
            

            try
            {
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    string nom = MyDataReader["Nom"].ToString();
                    string prenom = MyDataReader["Prenom"].ToString();
                    string DataNaissance = MyDataReader["DateNaissance"].ToString();
                    string IdBus = MyDataReader["IdBus"].ToString();
                    string IGroupe = MyDataReader["IGroupe"].ToString();
                    string ligneEnfant = $"{nom} {prenom}  {DataNaissance} {IGroupe} {IdBus}";
                    ListeBoxEnfant.Items.Add(ligneEnfant);
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
    }
}
