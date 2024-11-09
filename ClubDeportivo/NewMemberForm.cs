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

namespace ClubDeportivo
{
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionDB = Datos.Conexion.connection();

            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string document = txtDocument.Text;
            string birthday = dtpBirth.Text;
            // deberia hacer algo para que la fecha de nac se guarde unicamente en formato aaaa-mm-dd
            string gender = cboGender.Text;
            string email = txtEmail.Text;

            if (name.Length < 1 ||
                lastname.Length < 1 ||
                document.Length < 1 ||
                birthday.Length < 1 ||
                gender.Length < 1 ||
                email.Length < 1)
            {
                MessageBox.Show("Los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connectionDB.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connectionDB;
                    command.CommandText = ("insert into socio(nombre, apellido, documento, fecha_nacimiento, genero, email)" +
                        " values('" + txtName.Text + "', '" + txtLastName.Text + "', '" + txtDocument.Text + "', '" + dtpBirth.Text + "', '" + cboGender.Text + "', '" + txtEmail.Text + "')");
                    command.ExecuteNonQuery();
                    connectionDB.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                MessageBox.Show("Datos registrados correctamente");
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLastName.Clear();
            txtDocument.Clear();
            //txtBirth.Clear();
            txtEmail.Clear();
            cboGender.Text = "";
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpBirth.CustomFormat = "yyyy/MM/dd";
        }
    }
}