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
    public partial class Mostrar : Form
    {
        // 1. Campo estático privado para guardar la única instancia
        private static Mostrar _instance;

        // 2. Propiedad estática pública para acceder a la instancia
        public static Mostrar Instance
        {
            get
            {
                // Si la instancia no existe o ya ha sido cerrada/eliminada,
                // crea una nueva instancia.
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Mostrar();
                }
                return _instance;
            }
        }
        public Mostrar()
        {
            InitializeComponent();
            ConfigurarDataGridViewMostrar();
        }

        // Método para configurar las columnas del DataGridView (este no cambia)
        private void ConfigurarDataGridViewMostrar()
        {
            dgvMostrarDatos.AutoGenerateColumns = false;
            // ... (el resto de la configuración de columnas es la misma)
            dgvMostrarDatos.Columns.Add("MatriculaAlumno", "Matrícula");
            dgvMostrarDatos.Columns.Add("NombreAlumno", "Nombre");
            dgvMostrarDatos.Columns.Add("ApellidoAlumno", "Apellido");
            dgvMostrarDatos.Columns.Add("Materia", "Materia");
            dgvMostrarDatos.Columns.Add("Examen", "Examen");
            dgvMostrarDatos.Columns.Add("Calificacion1", "C1");
            dgvMostrarDatos.Columns.Add("Calificacion2", "C2");
            dgvMostrarDatos.Columns.Add("Calificacion3", "C3");
            dgvMostrarDatos.Columns.Add("Calificacion4", "C4");
            dgvMostrarDatos.Columns.Add("TotalCalificacion", "Total de Calificación");
            dgvMostrarDatos.Columns.Add("Clasificacion", "Clasificación");
            dgvMostrarDatos.Columns.Add("Estado", "Estado");

            dgvMostrarDatos.Columns["MatriculaAlumno"].DataPropertyName = "MatriculaAlumno";
            dgvMostrarDatos.Columns["NombreAlumno"].DataPropertyName = "NombreAlumno";
            dgvMostrarDatos.Columns["ApellidoAlumno"].DataPropertyName = "ApellidoAlumno";
            dgvMostrarDatos.Columns["Materia"].DataPropertyName = "Materia";
            dgvMostrarDatos.Columns["Examen"].DataPropertyName = "Examen";
            dgvMostrarDatos.Columns["Calificacion1"].DataPropertyName = "Calificacion1";
            dgvMostrarDatos.Columns["Calificacion2"].DataPropertyName = "Calificacion2";
            dgvMostrarDatos.Columns["Calificacion3"].DataPropertyName = "Calificacion3";
            dgvMostrarDatos.Columns["Calificacion4"].DataPropertyName = "Calificacion4";
            dgvMostrarDatos.Columns["TotalCalificacion"].DataPropertyName = "TotalCalificacion";
            dgvMostrarDatos.Columns["Clasificacion"].DataPropertyName = "Clasificacion";
            dgvMostrarDatos.Columns["Estado"].DataPropertyName = "Estado";
        }

        // El método CargarDatos se mantiene igual.
        public void CargarDatos(List<Calificacion> calificaciones)
        {
            dgvMostrarDatos.DataSource = null;
            dgvMostrarDatos.DataSource = calificaciones;
            dgvMostrarDatos.Refresh(); // Añade esta línea para asegurarte de que se refresca
        }

        private void dgvMostrarDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
