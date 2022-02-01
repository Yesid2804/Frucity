using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Entity;
using BLL;
using System.Windows.Forms;
using System.Linq;

namespace Presentacion
{
    public partial class FrmProveedor : Form
    {
        ProveedorService proveedorServices;
        ProductoService productoService;
        Proveedor proveedor;
        Producto producto;
        public FrmProveedor()
        {
            InitializeComponent();
            proveedorServices = new ProveedorService(ConfigConnection.connectionstring);
            productoService = new ProductoService(ConfigConnection.connectionstring);
            gbProducto.Enabled = false;
            BtmFinlizar.Enabled = false;
            BtmAñadirProducto.Enabled = false;
        }
        #region Mapeo y limpiado de campos
        private Proveedor MapearProveedor()
        {
            proveedor = new Proveedor();
            proveedor.NIT = txtNITProveedor.Text;
            proveedor.Nombre = txtNombreProveedor.Text;
            proveedor.RazonSocial = txtRazonSocialProveedor.Text;
            proveedor.Telefono = txtTelefonoProveedor.Text;
            proveedor.Direccion = txtDireccionProveedor.Text;
            return proveedor;
        }
        private Proveedor MapeoInverso(IList<Proveedor> proveedores)
        {
            foreach (var item in proveedores)
            {
                proveedor = new Proveedor();
                txtNITProveedor.Text = item.NIT;
                txtNombreProveedor.Text = item.Nombre;
                txtRazonSocialProveedor.Text = item.RazonSocial;
                txtTelefonoProveedor.Text = item.Telefono;
                txtDireccionProveedor.Text = item.Direccion;
                return item;
            }
            MessageBox.Show("Error", "OJO!!!!!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            return null;
        }
        private Producto MapearProucto()
        {
            producto = new Producto();
            producto.Nombre = txtNombreProducto.Text;
            producto.Catergoria = cmbCategoriaProducto.Text;
            producto.Presentacion = rtxtPresentacion.Text;
            producto.PrecioUnitario = decimal.Parse(txtPrecioProducto.Text);
            producto.Costo = decimal.Parse(txtCostoProducto.Text);
            producto.CodProveedor = txtNITProveedor.Text;
            producto.Cantidad = Convert.ToInt32(nudCantidad.Value);
            return producto;
        }
        private void LimpiarProducto()
        {
            txtNombreProducto.Text = "";
            cmbCategoriaProducto.Text = "";
            rtxtPresentacion.Text = "";
            txtPrecioProducto.Text = "";
            txtCostoProducto.Text = "";
            nudCantidad.Value = 1;
            
        }
        private void LimpiarProveedor()
        {
            txtNITProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtRazonSocialProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtDireccionProveedor.Text = "";
        }
        #endregion
        public bool ValidarCampoVacio(Control objeto, ErrorProvider errorProvider)
        {
            bool error = false;
            foreach (var item in objeto.Controls)
            {
                if (item is TextBox )
                {
                    TextBox obj = (TextBox)item;

                    if (obj.Text.Equals("") || obj.Text.Equals("Escribir..."))
                    {
                        errorProvider.SetError(obj, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                        error = false;
                    }
                }
                if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;
                    if (box.Text.Equals("") || box.Text.Equals("Escribir..."))
                    {
                        errorProvider.SetError(box, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(box, "");
                        error = false;
                    }
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown box = (NumericUpDown)item;
                    if (box.Value == 0 || box.Text.Equals(""))
                    {
                        errorProvider.SetError(box, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(box, "");
                        error = false;
                    }
                }
                if (item is RichTextBox)
                {
                    RichTextBox obj = (RichTextBox)item;

                    if (obj.Text.Equals("") || obj.Text.Equals("Escribir..."))
                    {
                        errorProvider.SetError(obj, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                        error = false;
                    }
                }

            }
            return error;
        }
        private void BtmRegistrarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = MapearProveedor();
                string mensaje = proveedorServices.Guardar(proveedor);
                MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbProducto.Enabled = true;
                BtmAñadirProducto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        public bool ValidarCampoCaracter(TextBox textBox, ErrorProvider errorProvider)
        {
            bool error = false;

            if (!textBox.Text.All(char.IsLetter))
            {
                errorProvider.SetError(textBox, "Debe Digitar Solo Caracteres");
                error = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                error = false;
            }
            return error;
        }
        public bool ValidarCampoNumero(TextBox textBox, ErrorProvider errorProvider)
        {
            try
            {
                decimal.Parse(textBox.Text);
                errorProvider.SetError(textBox, "");
                return true;
            }
            catch
            {
                errorProvider.SetError(textBox, "Debe Digitar Solo Numeros");
                return false;
            }
        }
        private void BtmAñadirProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //ValidarCampoVacio(this.gbProducto, eP_Proveedor);
                Producto producto = MapearProucto();
                string mensaje = productoService.Guardar(producto);
                var result = MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    LimpiarProducto();
                    BtmFinlizar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btmBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaRespuesta respuesta = new ConsultaRespuesta();
                if (txtNITProveedor.Text.Equals(""))
                {
                    MessageBox.Show("Campo de consulta vacio", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    respuesta = proveedorServices.ConsultaCodigo(txtNITProveedor.Text);
                    MapeoInverso(respuesta.Proveedores);
                    txtNombreProveedor.Enabled = false;
                    txtRazonSocialProveedor.Enabled = false;
                    txtTelefonoProveedor.Enabled = false;
                    txtDireccionProveedor.Enabled = false;
                    MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbProducto.Enabled = true;
                    BtmAñadirProducto.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtmCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Enabled = true;
            txtRazonSocialProveedor.Enabled = true;
            txtTelefonoProveedor.Enabled = true;
            txtDireccionProveedor.Enabled = true;
            LimpiarProveedor();
            LimpiarProducto();
            gbProducto.Enabled = false;
            BtmFinlizar.Enabled = false;
            BtmAñadirProducto.Enabled = false;
        }

        private void BtmFinlizar_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Enabled = true;
            txtRazonSocialProveedor.Enabled = true;
            txtTelefonoProveedor.Enabled = true;
            txtDireccionProveedor.Enabled = true;
            LimpiarProveedor();
            LimpiarProducto();
            gbProducto.Enabled = false;
            BtmFinlizar.Enabled = false;
            BtmAñadirProducto.Enabled = false;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
