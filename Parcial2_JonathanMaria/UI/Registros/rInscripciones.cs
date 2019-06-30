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
        public List<InscripcionDetalle> Detalle;

        public rInscripciones()
        {
            InitializeComponent();
            Detalle = new List<InscripcionDetalle>();
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
            EstudianteIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            PrecioCreditosNumericUpDown.Value = 0;
            AsignaturaIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            PrecioCreditosNumericUpDown.Value = 0;
            PrecioTextBox.Text = string.Empty;
            ValorTextBox.Text = string.Empty;

            this.Detalle = new List<InscripcionDetalle>();
            CargaGrid();
        }

        private Inscripciones LlenaClase()
        {
            Inscripciones Inscripcion = new Inscripciones();
            Inscripcion.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            Inscripcion.FechaInscripcion = FechaDeInscripcionDateTimePicker.Value;
            Inscripcion.EstudianteId = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            Inscripcion.PrecioCreditos = Convert.ToDecimal(PrecioCreditosNumericUpDown.Value);
            Inscripcion.Valor = Convert.ToDecimal(ValorTextBox.Text);
            Inscripcion.Detalle = this.Detalle;
            return Inscripcion;
        }

        private void LlenaCampos(Inscripciones Inscripcion)
        {
            InscripcionIdNumericUpDown.Value = Inscripcion.InscripcionId;
            FechaDeInscripcionDateTimePicker.Value = Inscripcion.FechaInscripcion;
            EstudianteIdNumericUpDown.Value = Inscripcion.EstudianteId;
            PrecioCreditosNumericUpDown.Value = Inscripcion.PrecioCreditos;
            ValorTextBox.Text = Convert.ToString(Inscripcion.Valor);
            Detalle = new List<InscripcionDetalle>();
            this.Detalle = Inscripcion.Detalle;
            CargaGrid();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            //List<InscripcionDetalle> Detalle = new List<InscripcionDetalle>();
            if (DetalleDataGridView.DataSource != null)
                Detalle = (List<InscripcionDetalle>)DetalleDataGridView.DataSource;
            this.Detalle.Add(
                new InscripcionDetalle(
                iDID: 0,
                inscripcionId: (int)InscripcionIdNumericUpDown.Value,
                asignaturaId: (int)AsignaturaIdNumericUpDown.Value,
                descripcion: DescripcionTextBox.Text,
                creditos: (int)CreditosNumericUpDown.Value,
                precio: Convert.ToDecimal(PrecioTextBox.Text)
            )
            );
            CargaGrid();
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
