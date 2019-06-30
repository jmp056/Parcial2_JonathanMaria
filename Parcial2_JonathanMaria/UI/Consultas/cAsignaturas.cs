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
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            var listado = new List<Asignaturas>();
            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0:
                        { 
                            listado = Repositorio.GetList(p => true);
                            break;
                        }

                    case 1:
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = Repositorio.GetList(p => p.AsignaturaId == id);
                            break;
                        }
                    case 2:
                        {
                            listado = Repositorio.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 3:
                        {
                            int Creditos = Convert.ToInt32(CriterioTextBox.Text);
                            listado = Repositorio.GetList(p => p.Creditos == Creditos);
                            break;
                        }
                }
               
            }
            else
            {
                listado = Repositorio.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
