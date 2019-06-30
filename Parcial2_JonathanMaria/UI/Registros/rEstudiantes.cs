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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            EstudianteIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            BalanceTextBox.Text = "0";
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes Estudiante = new Estudiantes();
            Estudiante.EstudianteId = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            Estudiante.Nombre = NombreTextBox.Text;
            Estudiante.FechaIngreso = FechaIngresoDateTimePicker.Value;
            Estudiante.Balance = Convert.ToDecimal(BalanceTextBox.Text);
            return Estudiante;
        }

        private void LlenaCampos(Estudiantes Estudiante)
        {
            EstudianteIdNumericUpDown.Value = Estudiante.EstudianteId;
            NombreTextBox.Text = Estudiante.Nombre;
            FechaIngresoDateTimePicker.Value = Estudiante.FechaIngreso;
            BalanceTextBox.Text = Convert.ToString(Estudiante.Balance);
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if(NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if(FechaIngresoDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaIngresoDateTimePicker, "La Fecha de Ingreso no puede ser mayor a la de hoy!");
                FechaIngresoDateTimePicker.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante = repositorio.Buscar((int)EstudianteIdNumericUpDown.Value);
            return Estudiante != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            int id;
            Estudiantes Estudiante = new Estudiantes();
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);
            Estudiante = repositorio.Buscar(id);
            if(Estudiante != null)
            {
                LlenaCampos(Estudiante);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Estudiante no encontrado!");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante;
            bool paso = false;
            if (!Validar())
                return;
            Estudiante = LlenaClase();
            if(EstudianteIdNumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(Estudiante);
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar este estudiante?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = repositorio.Modificar(Estudiante);
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
            if (MessageBox.Show("Esta seguro que desea eliminar este estudiante?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(EstudianteIdNumericUpDown.Text, out id);
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("El Estudiante fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El estudiante no pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }


    }
}