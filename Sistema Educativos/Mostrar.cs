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
    public partial class Mostrar : Form, IRefrescable
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        public void RefrescarDatos()
        {
            // Llama a la función que se encarga de cargar los datos
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
           
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            // Llama a este método también cuando el formulario se carga por primera vez
            CargarDatosEnDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar lógica para cuando se hace clic en una celda
        }
    }
}
