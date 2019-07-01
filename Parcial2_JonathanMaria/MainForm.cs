using Parcial2_JonathanMaria.UI.Consultas;
using Parcial2_JonathanMaria.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JonathanMaria
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes rE = new rEstudiantes();
            rE.ShowDialog();
        }

        private void RegistrarAsignatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas rA = new rAsignaturas();
            rA.ShowDialog();
        }

        private void RegistroDeInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripciones rI = new rInscripciones();
            rI.ShowDialog();
        }

        private void ConsultarAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignaturas cA = new cAsignaturas();
            cA.ShowDialog();
        }

        private void ConsultarEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantes cE = new cEstudiantes();
            cE.ShowDialog();
        }

        private void ConsultarInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cInscripciones cI = new cInscripciones();
            cI.ShowDialog();
        }
    }
}
