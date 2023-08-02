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
using System.Xml.Linq;

namespace CitasMedicas
{
    public partial class RegisterDoctorForm : Form
    {
        public RegisterDoctorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cleanFields()
        {
            txtName.Clear();
            txtLastName.Clear();
            numericUpDownAge.ResetText();
            listBoxSpecialities.ClearSelected();
            txtNumID.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            int age = Convert.ToInt32(numericUpDownAge.Value);
            string speciality = listBoxSpecialities.Text;
            string numDocument = txtNumID.Text;
            string sqlSetenceRegister =$"INSERT INTO doctors (firstName, lastName, age, specialty, numDocument) VALUES ('{name}', '{lastName}', {age}, '{speciality}', '{numDocument}')";

            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sqlSetenceRegister, connectionBD);
                command.ExecuteNonQuery();
                MessageBox.Show("Doctor register");
            }
            catch (MySqlException exception) 
            { 
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cleanFields();
                connectionBD.Close(); 
            }
        }
    }
}
