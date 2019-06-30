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
        }

        private void Limpiar()
        {
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

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante = repositorio.Buscar((int)EstudianteIdNumericUpDown.Value);
            return Estudiante != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante;
            Estudiante = LlenaClase();
            repositorio.Guardar(Estudiante);
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            int id;
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);
            repositorio.Eliminar(id);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            int id;
            Estudiantes Estudiante = new Estudiantes();
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);
            Estudiante = repositorio.Buscar(id);
            LlenaCampos(Estudiante);
        }
    }
}