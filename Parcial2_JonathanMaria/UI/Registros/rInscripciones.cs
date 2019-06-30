using Parcial2_JonathanMaria.BLL;
using Parcial2_JonathanMaria.DAL;
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
            ValorTextBox.Text = "0";
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
            Contexto contexto = new Contexto();
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            InscripcionIdNumericUpDown.Value = Inscripcion.InscripcionId;
            FechaDeInscripcionDateTimePicker.Value = Inscripcion.FechaInscripcion;
            EstudianteIdNumericUpDown.Value = Inscripcion.EstudianteId;
            //int id = Inscripcion.EstudianteId;
            NombreTextBox.Text = Convert.ToString(contexto.Estudiantes.Find(Inscripcion.EstudianteId).Nombre);
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
            decimal val = Convert.ToDecimal(ValorTextBox.Text) + Convert.ToDecimal(PrecioTextBox.Text);
            ValorTextBox.Text = Convert.ToString(val);
            CargaGrid();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Inscripciones Inscripcion;
            Inscripcion = LlenaClase();
            InscripcionesBLL.Guardar(Inscripcion);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones Inscripcion = new Inscripciones();
            int.TryParse(InscripcionIdNumericUpDown.Text, out id);
            Inscripcion = InscripcionesBLL.Buscar(id);
            LlenaCampos(Inscripcion);
        }

        private void PrecioCreditosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PrecioTextBox.Text = Convert.ToString(PrecioCreditosNumericUpDown.Value * CreditosNumericUpDown.Value);
        }

        private void CreditosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PrecioTextBox.Text = Convert.ToString(PrecioCreditosNumericUpDown.Value * CreditosNumericUpDown.Value);
        }

        private void SeleccionarAsignaturaButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas Asignatura = new Asignaturas();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            Asignatura = Repositorio.Buscar(id);
            DescripcionTextBox.Text = Asignatura.Descripcion;
            CreditosNumericUpDown.Value = Asignatura.Creditos;
        }
    }
}
