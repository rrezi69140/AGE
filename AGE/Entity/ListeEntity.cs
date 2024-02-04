using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE.Entity
{
    internal class ListeEntity
    {
        public SqlConnection MyConnecion = new SqlConnection("Data Source=DESKTOP-P2GM80O\\SQLEXPRESS01;Initial Catalog=GestioEnfant;Integrated Security=True");
        public string RequetteSQl;

        public void GetListListe(ComboBox ComboBoxListe)
        {
            RequetteSQl = "Select * from Liste";
            SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);


            try
            {
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    ComboBoxListe.Items.Add(MyDataReader.GetString(1));

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

        public void GetListListe(DataGridView DataGridBoxListe)
        {
            RequetteSQl = "Select NomListe from Liste";
           


            try
            {
                Debug.WriteLine("Tentative de recuperation de la liste des listes ");

                SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                DataGridBoxListe.Rows.Clear();
                while (MyDataReader.Read())
                {
                    DataGridBoxListe.Rows.Add(MyDataReader.GetValue(0).ToString());
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



        public void AddListe(string NomListe)
        {
            RequetteSQl = $"INSERT INTO Liste(NomListe) values('{NomListe}');";


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
                    MessageBox.Show("la Liste  a bien été ajouter ", "Succes de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void DeletListe(string ID)
        {
            RequetteSQl = $"DELETE From dbo.Liste WHERE  IdListe =  {ID} ";


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
                    MessageBox.Show("La liste a bien été Supprimer ", "Succes de la supression ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        public void ModifyList(string ID, string NomListe)
        {
            RequetteSQl = $"update Liste set NomListe = {NomListe} WHERE  IdListe =  {ID} ";


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
                    MessageBox.Show("La Liste  a bien été Modfier ", "Succes de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
