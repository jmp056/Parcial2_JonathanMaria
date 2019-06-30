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
            Inscripcion.Nombre = NombreTextBox.Text;
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
            NombreTextBox.Text = Inscripcion.Nombre;
            NombreTextBox.Text = Convert.ToString(contexto.Estudiantes.Find(Inscripcion.EstudianteId).Nombre);
            PrecioCreditosNumericUpDown.Value = Inscripcion.PrecioCreditos;
            ValorTextBox.Text = Convert.ToString(Inscripcion.Valor);
            Detalle = new List<InscripcionDetalle>();
            this.Detalle = Inscripcion.Detalle;
            CargaGrid();
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if(FechaDeInscripcionDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaDeInscripcionDateTimePicker, "La fecha de inscripcion no puede ser mayor a la fecha de hoy");
                FechaDeInscripcionDateTimePicker.Focus();
                paso = false;
            }
            if(NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "Debe seleccionar un estudiante");
                FechaDeInscripcionDateTimePicker.Focus();
                paso = false;
            }
            if(PrecioCreditosNumericUpDown.Value < 1 || PrecioCreditosNumericUpDown.Value > 5000)
            {
                MyErrorProvider.SetError(PrecioCreditosNumericUpDown, "El precio de los creditos debe estar entre 1 y 5,000");
                PrecioCreditosNumericUpDown.Focus();
                paso = false;
            }
            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe agregar alguna asignatura!!!");
                AsignaturaIdNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            Inscripciones Inscripcion = repositorio.Buscar((int)InscripcionIdNumericUpDown.Value);
            return Inscripcion != null;
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Inscripciones Inscripcion = new Inscripciones();
            int.TryParse(InscripcionIdNumericUpDown.Text, out id);
            Inscripcion = InscripcionesBLL.Buscar(id);
            if (Inscripcion != null)
            {
                LlenaCampos(Inscripcion);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Inscripcion no encontrada!");

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
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
            Inscripciones Inscripcion;
            bool paso = false;
            if (!Validar())
                return;
            Inscripcion = LlenaClase();
            if(InscripcionIdNumericUpDown.Value == 0)
            {
                paso = InscripcionesBLL.Guardar(Inscripcion);
                MessageBox.Show("Guardada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar esta inscripcion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = InscripcionesBLL.Modificar(Inscripcion);
                    MessageBox.Show("Modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar esta inscripcion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(EstudianteIdNumericUpDown.Text, out id);
                if (InscripcionesBLL.Eliminar(id))
                {
                    MessageBox.Show("La inscripcion fue eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("La inscripcion no pudo ser eliminada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
