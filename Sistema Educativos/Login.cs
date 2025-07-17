using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Educativos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aqui puedes agregar la logica para validar el usuario y la clave 
            {
                if (txtUsuario.Text == "admin" && txtClave.Text == "1234")
                {
                    FormPrincipal main = new FormPrincipal();
                    main.Show();
                    this.Hide(); // Oculta el formulario de login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
