using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Formulario de Centro
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro frmCentro = new FrmCentro();
            frmCentro.ShowDialog();

        }
        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros listaCentros = new ListaCentros();
            listaCentros.ShowDialog();
        }

        //Formulario de Profesor
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor frmProfesor = new FrmProfesor();
            frmProfesor.ShowDialog();

        }
        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores listaProfesores = new ListaProfesores();
            listaProfesores.ShowDialog();
        }

        //Formulario de Estudiante
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmEstudiante = new FrmEstudiante();
            frmEstudiante.ShowDialog();

        }
        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes listaEstudiantes = new ListaEstudiantes();
            listaEstudiantes.ShowDialog();
        }
        //Formulario de Personal

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal frmPersonal = new FrmPersonal();
            frmPersonal.ShowDialog();

        }
        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTrabajadores listaTrabajadores = new ListaTrabajadores();
            listaTrabajadores.ShowDialog();
        }

    }
}
