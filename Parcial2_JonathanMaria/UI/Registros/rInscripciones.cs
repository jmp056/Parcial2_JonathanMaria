using Parcial2_JonathanMaria.BLL;
using Parcial2_JonathanMaria.Entidades;
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
    public partial class rInscripciones : Form
    {
        public List<InscripcionDetalle> Detalle { get; set; }
        public rInscripciones()
        {
            InitializeComponent();
        }
        private void CargaGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            InscripcionIdNumericUpDown.Value = 0;
            FechaDeInscripcionDateTimePicker.Value = DateTime.Now;
            EstudianteIdTextBox.Text = string.Empty;
            NombreTextBox.Text = String.Empty;
            this.Detalle = new List<InscripcionDetalle>();
            CargaGrid();
            ValorTextBox.Text = "0";
        }

        private Inscripciones LlenaClase()
        {
            Inscripciones Inscripcion = new Inscripciones();
            Inscripcion.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            Inscripcion.FechaInscripcion = FechaDeInscripcionDateTimePicker.Value;
            Inscripcion.EstudianteId = Convert.ToInt32(EstudianteIdTextBox.Text);
            Inscripcion.Nombre = NombreTextBox.Text;
            Inscripcion.Detalle = this.Detalle;
            Inscripcion.Valor = Convert.ToDecimal(ValorTextBox.Text);
            return Inscripcion;
        }

        private void LlenaCampos(Inscripciones Inscripcion)
        {
            InscripcionIdNumericUpDown.Value = Inscripcion.InscripcionId;
            FechaDeInscripcionDateTimePicker.Value = Inscripcion.FechaInscripcion;
            EstudianteIdTextBox.Text = Convert.ToString(Inscripcion.EstudianteId);
            NombreTextBox.Text = Inscripcion.Nombre;
            this.Detalle = Inscripcion.Detalle;
            CargaGrid();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones Inscripcion = new Inscripciones();
            int.TryParse(InscripcionIdNumericUpDown.Text, out id);
            Inscripcion = InscripcionesBLL.Buscar(id);
            LlenaCampos(Inscripcion);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones Inscripcion;
            Inscripcion = LlenaClase();
            InscripcionesBLL.Guardar(Inscripcion);
            Limpiar();
        }
    }
}
