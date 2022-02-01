using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Entity;
using BLL;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCotizacion : Form
    {
        ProveedorService proveedorServices;
        ProductoService productoService;
        FacturaCotizacionService cotizacionService;
        FacturaCotizacion FacturaCotizacion = new FacturaCotizacion();
        DetalleCotizacion detalleCotizacion = new DetalleCotizacion();
        Proveedor proveedor;
        bool _var = false;

        Producto producto;
        public FrmCotizacion()
        {
            InitializeComponent();
            proveedorServices = new ProveedorService(ConfigConnection.connectionstring);
            productoService = new ProductoService(ConfigConnection.connectionstring);
            cotizacionService = new FacturaCotizacionService(ConfigConnection.connectionstring);
            gbInfoProducto.Enabled = false;
            BtmFinlizar.Enabled = false;
            txtFechaCotizacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private FacturaCotizacion MapeoCotizacion()
        {
            FacturaCotizacion cotizacion = new FacturaCotizacion();
            cotizacion.FechaExpedicion = dtpFecha.Value;
            cotizacion.Total = decimal.Parse(txtTotal.Text);
            cotizacion.NIT = txtNitProveedor.Text;
            return cotizacion;
        }
        private Proveedor MapeoInversoProveedor(IList<Proveedor> proveedores)
        {
            foreach (var item in proveedores)
            {
                proveedor = new Proveedor();
                txtNitProveedor.Text = item.NIT;
                txtNombreProveedor.Text = item.Nombre;
                txtTelefonoProveedor.Text = item.Telefono;
                txtDireccionProveedor.Text = item.Direccion;
                return item;
            }
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
        private Producto MapeoInversoProucto(IList<Producto> prouctos)
        {
            foreach (var item in prouctos)
            {
                proveedor = new Proveedor();
                txtCodProducto.Text = Convert.ToString(item.CodigoProducto);
                txtNombreProducto.Text = item.Nombre;
                return item;
            }
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaRespuesta respuesta = new ConsultaRespuesta();
                if (txtNitProveedor.Text.Equals(""))
                {
                    MessageBox.Show("Campo de consulta vacio", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    respuesta = proveedorServices.ConsultaCodigo(txtNitProveedor.Text);
                    MapeoInversoProveedor(respuesta.Proveedores);
                    MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _var = true;
                    gbInfoProducto.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();

                ConsultaRespuesta respuesta = new ConsultaRespuesta();
                if (txtCodProducto.Text.Equals(""))
                {
                    MessageBox.Show("Campo de consulta vacio", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    respuesta = productoService.ConsultaProductosProveedor(txtNitProveedor.Text,txtCodProducto.Text);
                    MapeoInversoProucto(respuesta.Productos);
                    _var = true;
                    gbInfoProducto.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtmFinlizar_Click(object sender, EventArgs e)
        {
            detalleCotizacion.IdFactura = cotizacionService.ContarCotizacion() + 1;
            var cot = MapeoCotizacion();
            MessageBox.Show(cotizacionService.GuardarFactura(cot));
        }

        private void PintarTabla()
        {
            dgvCotizacion.DataSource = null;
            dgvCotizacion.Rows.Clear();

            if (FacturaCotizacion.Detalles != null)
            {
                foreach (var item in FacturaCotizacion.Detalles)
                {
                    int n = dgvCotizacion.Rows.Add();
                    dgvCotizacion.Rows[n].Cells[0].Value = Convert.ToString(item.IdProducto);
                    dgvCotizacion.Rows[n].Cells[1].Value = item.DescripcionProducto;
                    dgvCotizacion.Rows[n].Cells[2].Value = Convert.ToString(item.CategoriaProducto);
                    dgvCotizacion.Rows[n].Cells[3].Value = Convert.ToString(item.Presentacion);
                    dgvCotizacion.Rows[n].Cells[4].Value = Convert.ToString(item.Cantidad);
                    dgvCotizacion.Rows[n].Cells[5].Value = Convert.ToString(item.PrecioUnitario);
                    dgvCotizacion.Rows[n].Cells[6].Value = Convert.ToString(item.CostoProducto);
                    dgvCotizacion.Rows[n].Cells[7].Value = Convert.ToString(item.ValorTotal);
                }
            }
        }

        private void BtmAñadirProducto_Click(object sender, EventArgs e)
        {
            FacturaCotizacion.AgregarDetalle(productoService.Verificar(int.Parse(txtCodProducto.Text)),int.Parse(txtCantidadProducto.Text));
            txtTotal.Text = Convert.ToString(FacturaCotizacion.SubTotalCal);
            PintarTabla();
            BtmFinlizar.Enabled = true;
        }

        private void BtmCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
