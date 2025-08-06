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
    
    public partial class Mostrar : Form, IRefrescable
    {
        public Mostrar()
        {
            InitializeComponent();
            ConfigurarDataGridViewCalificaciones(); // Llama a la configuración una sola vez
            RefrescarDatos(); // Llama al método de refresco para la carga inicial
        }
        public void RefrescarDatos()
        {
            
            dataGridView1.DataSource = null; // Limpia la fuente de datos actual
            dataGridView1.DataSource = AreaCalificacion.ListaCalificaciones; // Asigna la lista actualizada
            dataGridView1.Refresh(); // Vuelve a dibujar el DataGridView
        }

        
        private void ConfigurarDataGridViewCalificaciones()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("MatriculaAlumno", "Matrícula");
            dataGridView1.Columns.Add("NombreAlumno", "Nombre");
            dataGridView1.Columns.Add("ApellidoAlumno", "Apellido");
            dataGridView1.Columns.Add("Materia", "Materia");
            dataGridView1.Columns.Add("Examen", "Examen");
            dataGridView1.Columns.Add("Calificacion1", "C1");
            dataGridView1.Columns.Add("Calificacion2", "C2");
            dataGridView1.Columns.Add("Calificacion3", "C3");
            dataGridView1.Columns.Add("Calificacion4", "C4");
            dataGridView1.Columns.Add("TotalCalificacion", "Total de Calificación");
            dataGridView1.Columns.Add("Clasificacion", "Clasificación");
            dataGridView1.Columns.Add("Estado", "Estado");

            dataGridView1.Columns["MatriculaAlumno"].DataPropertyName = "MatriculaAlumno";
            dataGridView1.Columns["NombreAlumno"].DataPropertyName = "NombreAlumno";
            dataGridView1.Columns["ApellidoAlumno"].DataPropertyName = "ApellidoAlumno";
            dataGridView1.Columns["Materia"].DataPropertyName = "Materia";
            dataGridView1.Columns["Examen"].DataPropertyName = "Examen";
            dataGridView1.Columns["Calificacion1"].DataPropertyName = "Calificacion1";
            dataGridView1.Columns["Calificacion2"].DataPropertyName = "Calificacion2";
            dataGridView1.Columns["Calificacion3"].DataPropertyName = "Calificacion3";
            dataGridView1.Columns["Calificacion4"].DataPropertyName = "Calificacion4";
            dataGridView1.Columns["TotalCalificacion"].DataPropertyName = "TotalCalificacion";
            dataGridView1.Columns["Clasificacion"].DataPropertyName = "Clasificacion";
            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}