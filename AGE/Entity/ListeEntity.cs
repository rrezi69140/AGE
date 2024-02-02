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

    }
}
