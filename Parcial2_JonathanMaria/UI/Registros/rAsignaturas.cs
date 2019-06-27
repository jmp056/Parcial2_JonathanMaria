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
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            AsignaturaIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CreditosNumericUpDown.Value = 0;
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas Asignatura = new Asignaturas();
            Asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            Asignatura.Descripcion = DescripcionTextBox.Text;
            Asignatura.Creditos = Convert.ToInt32(CreditosNumericUpDown.Value);
            return Asignatura;
        }

        private void LlenaCampos(Asignaturas Asignatura)
        {
            AsignaturaIdNumericUpDown.Value = Asignatura.AsignaturaId;
            DescripcionTextBox.Text = Asignatura.Descripcion;
            CreditosNumericUpDown.Value = Asignatura.Creditos;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = repositorio.Buscar((int)AsignaturaIdNumericUpDown.Value);
            return Asignatura != null;
        }
        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas Asignatura = new Asignaturas();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            Asignatura = repositorio.Buscar(id);
            LlenaCampos(Asignatura);
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura;
            Asignatura = LlenaClase();
            repositorio.Guardar(Asignatura);
        }
        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            int id;
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            repositorio.Eliminar(id);
        }
    }
}
