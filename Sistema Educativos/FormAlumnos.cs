using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica;

namespace Sistema_Educativos
{
    public partial class FormAlumnos : Form
    {
        // Lista estática para almacenar los alumnos, accesible desde otros formularios.
        // En una aplicación real, esto sería una base de datos o un servicio de datos.
        public static List<Alumno> ListaAlumnos = new List<Alumno>();
        public FormAlumnos()
        {
            InitializeComponent();
            ConfigurarDataGridViewAlumnos(); // Configura las columnas del DataGridView.
            CargarAlumnosDataGridView(); // Carga los alumnos existentes al iniciar.
        }
        // Método para configurar las columnas del DataGridView1.
        private void ConfigurarDataGridViewAlumnos()
        {
            // Se asume que tienes un DataGridView llamado 'dataGridView1' en tu formulario.
            dataGridView1.AutoGenerateColumns = false; // Desactiva la generación automática de columnas.

            // Añade las columnas manualmente.
            dataGridView1.Columns.Add("Matricula", "Matrícula");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Edad", "Edad");

            // Asigna las propiedades de datos a las columnas.
            dataGridView1.Columns["Matricula"].DataPropertyName = "Matricula";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["Apellido"].DataPropertyName = "Apellido";
            dataGridView1.Columns["Edad"].DataPropertyName = "Edad";
        }

        // Método para cargar la lista de alumnos en el DataGridView1.
        public void CargarAlumnosDataGridView()
        {
            // Asigna la lista de alumnos como fuente de datos para el DataGridView.
            dataGridView1.DataSource = null; // Limpia la fuente de datos actual.
            dataGridView1.DataSource = ListaAlumnos; // Asigna la nueva fuente de datos.
            dataGridView1.Refresh(); // Refresca el DataGridView para mostrar los cambios.
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarAlumnosDataGridView();
            MessageBox.Show("👀 Lista de alumnos actualizada en pantalla.", "Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        { // Obtener los valores de los TextBox (se asume TextBox llamados txtMatricula, txtNombre, txtApellido, txtEdad).
            string matricula = txtmatricula.Text.Trim();
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            int edad;

            // Validaciones de entrada.
            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtedad.Text.Trim(), out edad) || edad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar matrícula única.
            if (ListaAlumnos.Any(a => a.Matricula.Equals(matricula, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"La matrícula '{matricula}' ya existe. Por favor, ingrese una matrícula única.", "Matrícula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de Alumno.
            Alumno nuevoAlumno = new Alumno(matricula, nombre, apellido, edad);
            // Añadir el nuevo alumno a la lista.
            ListaAlumnos.Add(nuevoAlumno);
            // Actualizar el DataGridView.
            CargarAlumnosDataGridView();

            MessageBox.Show("Alumno registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario.
            txtmatricula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();

        }
        // Método para actualizar datos de un alumno según matrícula
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string matricula = txtmatricula.Text.Trim();

            var alumno = ListaAlumnos.FirstOrDefault(a => a.Matricula.Equals(matricula, StringComparison.OrdinalIgnoreCase));

            if (alumno == null)
            {
                MessageBox.Show("❌ No se encontró un alumno con esa matrícula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validaciones
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text))
            {
                MessageBox.Show("Por favor, complete nombre y apellido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtedad.Text.Trim(), out int nuevaEdad) || nuevaEdad <= 0)
            {
                MessageBox.Show("Edad inválida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualización de datos
            alumno.Nombre = txtnombre.Text.Trim();
            alumno.Apellido = txtapellido.Text.Trim();
            alumno.Edad = nuevaEdad;

            CargarAlumnosDataGridView(); // Refresca el DataGridView
            MessageBox.Show("✅ Alumno actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: limpiar campos
            txtmatricula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
