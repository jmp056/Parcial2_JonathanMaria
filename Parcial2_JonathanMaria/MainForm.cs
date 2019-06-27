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
    }
}
