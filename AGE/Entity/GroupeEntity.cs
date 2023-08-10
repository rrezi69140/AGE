﻿using System;
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
    }
}
