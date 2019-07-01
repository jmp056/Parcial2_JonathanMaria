using Parcial2_JonathanMaria.BLL;
using Parcial2_JonathanMaria.DAL;
using Parcial2_JonathanMaria.Entidades;
using Parcial2_JonathanMaria.UI.Consultas;
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

        private bool ExisteEnElDetalle(int id)
        {
            bool paso = false ;
            foreach (DataGridViewRow asignatura in DetalleDataGridView.Rows)
            {
                if (id == Convert.ToInt32(asignatura.Cells["AsignaturaId"].Value))
                {
                    paso = true;
                    break;
                }
            }
            return paso;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante = Repositorio.Buscar(Convert.ToInt32(EstudianteIdNumericUpDown.Value));
            bool paso = true;
            if(FechaDeInscripcionDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaDeInscripcionDateTimePicker, "La fecha de inscripcion no puede ser mayor a la fecha de hoy");
                FechaDeInscripcionDateTimePicker.Focus();
                paso = false;
            }

            if (EstudianteIdNumericUpDown.Value == 0 || NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EstudianteIdNumericUpDown, "Debe seleccionar un estudiante");
                EstudianteIdNumericUpDown.Focus();
                paso = false;
            }

            if (Estudiante == null || Estudiante.Nombre != NombreTextBox.Text)
            {
                MyErrorProvider.SetError(CargarEstudianteButton, "Debe cargar un estudiante");
                CargarEstudianteButton.Focus();
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
            MyErrorProvider.Clear();
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas Asignatura = new Asignaturas();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            Asignatura = Repositorio.Buscar(id);
            if (Asignatura == null || Asignatura.Descripcion != DescripcionTextBox.Text)
            {
                MyErrorProvider.SetError(CargarAsignaturaButton, "Debe cargar la asignatura");
                AsignaturaIdNumericUpDown.Focus();
            }
            else if(PrecioCreditosNumericUpDown.Value < 1 || PrecioCreditosNumericUpDown.Value > 5000)
            {
                MyErrorProvider.SetError(PrecioCreditosNumericUpDown, "El precio de los creditos debe estar entre 1 & 5,000");
                PrecioCreditosNumericUpDown.Focus();
            }
            else if (ExisteEnElDetalle(Convert.ToInt32(AsignaturaIdNumericUpDown.Value)) == true)
            {
                MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "Esta asignatura ya fue agregada!");
            }
            else
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
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones Inscripcion;
            bool paso = false;
            if (!Validar())
                return;
            Inscripcion = LlenaClase();
            if (InscripcionIdNumericUpDown.Value == 0)
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

        private void PrecioCreditosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PrecioTextBox.Text = Convert.ToString(PrecioCreditosNumericUpDown.Value * CreditosNumericUpDown.Value);
        }

        private void CreditosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PrecioTextBox.Text = Convert.ToString(PrecioCreditosNumericUpDown.Value * CreditosNumericUpDown.Value);
        }

        private void RegistroAsignaturasButton_Click(object sender, EventArgs e)
        {
            rAsignaturas rA= new rAsignaturas();
            rA.ShowDialog();
        }

        private void ConsultarAsignaturasButton_Click(object sender, EventArgs e)
        {
            cAsignaturas cA = new cAsignaturas();
            cA.ShowDialog();
        }

        private void RegistroEstudiantesButton_Click(object sender, EventArgs e)
        {
            rEstudiantes rE = new rEstudiantes();
            rE.ShowDialog();
        }

        private void ConsultaEstudiantesButton_Click(object sender, EventArgs e)
            {
                cEstudiantes cE = new cEstudiantes();
                cE.ShowDialog();
            }

        private void CargarAsignaturaButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas Asignatura = new Asignaturas();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            Asignatura = Repositorio.Buscar(id);
            if (Asignatura != null)
            {
                DescripcionTextBox.Text = Asignatura.Descripcion;
                CreditosNumericUpDown.Value = Asignatura.Creditos;
            }
            else
            {
                MessageBox.Show("Asignatura no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTextBox.Text = string.Empty;
                CreditosNumericUpDown.Value = 0;
            }
        }

        private void CargarEstudianteButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            int id;
            Estudiantes Estudiante = new Estudiantes();
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);
            Estudiante = Repositorio.Buscar(id);
            if (Estudiante != null)
            {
                NombreTextBox.Text = Estudiante.Nombre;
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTextBox.Text = string.Empty;
                DescripcionTextBox.Text = string.Empty;
                CreditosNumericUpDown.Value = 0;
            }
        }

        private void RemoverAsignaturaButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargaGrid();
                decimal val = 0;
                foreach (DataGridViewRow asig in DetalleDataGridView.Rows)
                {
                    val += Convert.ToDecimal(asig.Cells["Precio"].Value);
                }
                ValorTextBox.Text = Convert.ToString(val);
            }
        }
    }
}
