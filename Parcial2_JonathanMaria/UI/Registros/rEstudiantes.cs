using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JonathanMaria.UI.Registros
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteIdNumericUpDown.Value = 0;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
