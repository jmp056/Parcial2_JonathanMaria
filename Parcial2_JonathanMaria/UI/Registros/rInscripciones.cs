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
        public List<DetalleInscripcion> Detalle { get; set; }
        public RProductos()
        {
            InitializeComponent();
            this.Detalle = new List<PreciosDetalle>();
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            LlenaComboBox();
        }
        private void CargaGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            IdProductoNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            ExistenciaNumericUpDown.Value = 0;
            CostoNumericUpDown.Value = 0;
            ValorInventarioTextBox.Text = string.Empty;
            UbicacionComboBox.Text = string.Empty;

            this.Detalle = new List<PreciosDetalle>();
            CargaGrid();
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.ProductoId = Convert.ToInt32(IdProductoNumericUpDown.Value);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistenciaNumericUpDown.Value);
            producto.Costo = Convert.ToSingle(CostoNumericUpDown.Value);
            producto.ValorEnInventario = Convert.ToSingle(ValorInventarioTextBox.Text);
            producto.Ubicacion = UbicacionComboBox.Text;
            producto.Precios = this.Detalle;
            return producto;
        }
        private void LlenaCampos(Productos producto)
        {
            IdProductoNumericUpDown.Value = producto.ProductoId;
            DescripcionTextBox.Text = producto.Descripcion;
            ExistenciaNumericUpDown.Value = producto.Existencia;
            CostoNumericUpDown.Value = Convert.ToDecimal(producto.Costo);
            ValorInventarioTextBox.Text = Convert.ToString(producto.ValorEnInventario);
            UbicacionComboBox.Text = producto.Ubicacion;
            this.Detalle = producto.Precios;
            CargaGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if (ExistenciaNumericUpDown.Value < 1)
            {
                MyErrorProvider.SetError(ExistenciaNumericUpDown, "La cantidad en existencia no puede ser negativo o 0");
                ExistenciaNumericUpDown.Focus();
                paso = false;
            }

            if (ExistenciaNumericUpDown.Value > 999999999)
            {
                MyErrorProvider.SetError(ExistenciaNumericUpDown, "La cantidad en existencia no puede ser mayor a 999,999,999");
                ExistenciaNumericUpDown.Focus();
                paso = false;
            }

            if (CostoNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El costo del producto no puede ser menor que 0");
                CostoNumericUpDown.Focus();
                paso = false;
            }

            if (CostoNumericUpDown.Value > 999999999)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El precio del producto no puede ser mayor que 999,999,999");
                CostoNumericUpDown.Focus();
                paso = false;
            }

            if (UbicacionComboBox.SelectedIndex.Equals(-1))
            {
                MyErrorProvider.SetError(UbicacionComboBox, "Eliga una ubicacion para el producto");
                UbicacionComboBox.Focus();
                paso = false;
            }
            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe agregar algun precio!!!");
                TipoPrecioTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void ActualizaInventario()
        {
            Inventarios inventario = new Inventarios();
            var listado = new List<Productos>();
            listado = ProductosBLL.GetList(p => true);
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
            double tot = 0;
            foreach (DataGridViewRow produ in ConsultaDataGridView.Rows)
            {
                tot += Convert.ToDouble(produ.Cells["ValorEnInventario"].Value);
            }
            inventario.InventarioId = 1;
            inventario.Valor = Convert.ToSingle(tot);
            if (InventariosBLL.Buscar(1) == null)
                InventariosBLL.Guardar(inventario);
            else
                InventariosBLL.Modificar(inventario);
        }

        public void LlenaComboBox()
        {
            var ubicaciones = new List<Ubicaciones>();
            ubicaciones = UbicacionesBLL.GetList(p => true);
            UbicacionComboBox.DataSource = ubicaciones;
            UbicacionComboBox.DisplayMember = "descripcion";
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos producto = ProductosBLL.Buscar((int)IdProductoNumericUpDown.Value);
            return producto != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            AdvertenciaErrorProvider.Clear();
            MyErrorProvider.Clear();
            int id;
            Productos producto = new Productos();
            int.TryParse(IdProductoNumericUpDown.Text, out id);
            producto = ProductosBLL.Buscar(id);
            if (producto != null)
            {
                MessageBox.Show("Producto encontrado");
                LlenaCampos(producto);
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
                AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            MyErrorProvider.Clear();
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            EliminarButton.Enabled = false;
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;
            if (!Validar())
                return;
            producto = LlenaClase();
            if (IdProductoNumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(producto);
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = ProductosBLL.Modificar(producto);
                    MessageBox.Show("Modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            ActualizaInventario();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(IdProductoNumericUpDown.Text, out id);
                Limpiar();
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("El producto fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    IdProductoNumericUpDown.Enabled = true;
                    EliminarButton.Enabled = false;
                }
                else
                    MessageBox.Show("El producto no pudo ser eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            }
            else
                return;
            ActualizaInventario();
        }

        private void ExistenciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventarioTextBox.Text = Convert.ToString(Convert.ToInt32(ExistenciaNumericUpDown.Value) * CostoNumericUpDown.Value);
        }

        private void CostoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventarioTextBox.Text = Convert.ToString(Convert.ToInt32(ExistenciaNumericUpDown.Value) * CostoNumericUpDown.Value);
        }

        private void AgregarUbicacionButton_Click(object sender, EventArgs e)
        {
            RUbicaciones Ru = new RUbicaciones();
            Ru.ShowDialog();
            LlenaComboBox();
        }

        private void AgregarPrecioButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<PreciosDetalle>)DetalleDataGridView.DataSource;
            this.Detalle.Add(
                new PreciosDetalle(
                precioId: 0,
                productoId: (int)IdProductoNumericUpDown.Value,
                tipoPrecio: TipoPrecioTextBox.Text,
                precio: PrecioNumericUpDown.Value
            )
            );
            CargaGrid();
            TipoPrecioTextBox.Clear();
            PrecioNumericUpDown.Value = 0;
            TipoPrecioTextBox.Focus();
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargaGrid();
            }
        }
    }
}
