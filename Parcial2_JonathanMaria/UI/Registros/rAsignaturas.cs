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
            EliminarButton.Enabled = false;
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();
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

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (CreditosNumericUpDown.Value < 1 || CreditosNumericUpDown.Value > 5)
            {
                MyErrorProvider.SetError(CreditosNumericUpDown, "La cantidad de creditos de una materia tienen que estar entre 1 y 5");
                CreditosNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = Repositorio.Buscar((int)AsignaturaIdNumericUpDown.Value);
            return Asignatura != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas Asignatura = new Asignaturas();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            Asignatura = repositorio.Buscar(id);
            if (Asignatura != null)
            {
                LlenaCampos(Asignatura);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Asignatura no encontrada!");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura;
            bool paso = false;
            if (!Validar())
                return;
            Asignatura = LlenaClase();
            if (AsignaturasBLL.Existe(Asignatura.Descripcion) == true)
            {
                MessageBox.Show("Ya esta asignatura existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AsignaturaIdNumericUpDown.Value == 0)
                {
                    paso = repositorio.Guardar(Asignatura);
                    MessageBox.Show("Guardada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar una asignatura que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Esta seguro que desea modificar esta asignatura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        paso = repositorio.Modificar(Asignatura);
                        MessageBox.Show("Modificada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                        return;
                }
                if (!paso)
                    MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar esta asignatura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("La asignatura fue eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("La asignatura no pudo ser eliminada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
