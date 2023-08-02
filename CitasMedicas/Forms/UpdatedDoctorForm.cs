using CitasMedicas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMedicas.Forms
{
    public partial class UpdatedDoctorForm : Form
    {
        public UpdatedDoctorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numID = txtNumIDUpdated.Text;
            MySqlDataReader mySqlDataReader = null;
            string sqlSetenceSelect = $"SELECT firstName, lastName, age, specialty FROM doctors WHERE numDocument LIKE '{numID}' LIMIT 1";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();

            try
            {
                MySqlCommand command= new MySqlCommand(sqlSetenceSelect, connectionBD);
                mySqlDataReader = command.ExecuteReader();

                txtNumIDUpdated.Enabled = false;
                btnUpdate.Enabled = true;

                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtNameUpdate.Text = mySqlDataReader.GetString(0);
                        txtLastNameUpdate.Text = mySqlDataReader.GetString(1);
                        numericUpDownAgeUpdate.Text = mySqlDataReader.GetString(2);
                        listBoxSpecialitiesUpdate.Text = mySqlDataReader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("Doctor not found");
                    btnUpdate.Enabled = false;
                    txtNumIDUpdated.Enabled=true;
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show($"Error find it : {exception}");
            }
            finally
            {
                connectionBD.Close(); 
            }
        }

        public void cleanFields()
        {
            txtNumIDUpdated.Clear();
            txtNameUpdate.Clear();
            txtLastNameUpdate.Clear();
            numericUpDownAgeUpdate.ResetText();
            listBoxSpecialitiesUpdate.ClearSelected();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string numID = txtNumIDUpdated.Text;
            string name = txtNameUpdate.Text;
            string lastName = txtLastNameUpdate.Text;
            string age = numericUpDownAgeUpdate.Text;
            string speciality = listBoxSpecialitiesUpdate.Text;

            string sqlSetenceUpdated = $"UPDATE doctors SET firstName ='{name}', lastName='{lastName}', age={age}, specialty='{speciality}' WHERE numDocument ={numID} ";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sqlSetenceUpdated, connectionBD);
                command.ExecuteNonQuery();
                MessageBox.Show("Information was updated");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show($"Error update : {exception}");
            }
            finally
            {
                cleanFields();
                connectionBD.Close();
            }
        }
    }
}
