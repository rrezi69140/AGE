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
    internal class BusEntity
    {
        public SqlConnection MyConnecion = new SqlConnection("Data Source=DESKTOP-1K0GE9A\\SQLEXPRESS;Initial Catalog=GestioEnfant;Integrated Security=True");
        public string RequetteSQl;

        public void GetListBus(ComboBox ComboBoxBus)
        {
            RequetteSQl = "Select LibeleBus  From Bus";
            SqlCommand MyCommand = new SqlCommand(RequetteSQl, MyConnecion);
            

            try
            {
                MyConnecion.Open();
                MyCommand.ExecuteNonQuery();
                SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    ComboBoxBus.Items.Add(MyDataReader.GetString(0));
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

        public void GetListEnfantBus(ComboBox ComboBoxBus, DataGridView dataGridView)
        {



            string BusSelectionner;
            BusSelectionner = ComboBoxBus.SelectedItem.ToString();


            RequetteSQl = $"Select *  From Membre M join Bus B ON M.IGroupe = B.IdBus where B.LibeleBus = '{BusSelectionner}'";
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
