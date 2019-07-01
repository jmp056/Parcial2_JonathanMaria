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

namespace Parcial2_JonathanMaria.UI.Consultas
{
    public partial class cInscripciones : Form
    {
        public cInscripciones()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> Repositorio = new RepositorioBase<Inscripciones>();
            var Listado = new List<Inscripciones>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            Listado = Repositorio.GetList(p => true);
                            break;
                        }

                    case 1:
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.InscripcionId == id);
                            break;
                        }
                    case 2:
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.EstudianteId == id);
                            break;
                        }
                    case 3:
                        {
                            Listado = Repositorio.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                            break;
                        }
                }

            }
            else
            {
                Listado = Repositorio.GetList(p => true);
            }
            if (FiltrarFechaCheckBox.Checked == true)
                Listado = Listado.Where(p => p.FechaInscripcion.Date >= DesdeDateTimePicker.Value.Date && p.FechaInscripcion.Date <= HastaDateTimePicker.Value.Date).ToList();
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = Listado;
        }
    }
}
