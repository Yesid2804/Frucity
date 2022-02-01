using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Linq;
namespace Presentacion
{
    public partial class FrmReportes : Form
    {
        FacturaVentaService VentaService;
        FacturaCotizacionService Cotizacionservice;
        List<FacturaCotizacion> cotizaciones;
        List<FacturaVenta> ventas;
        public FrmReportes()
        {
            Cotizacionservice = new FacturaCotizacionService(ConfigConnection.connectionstring);
            VentaService = new FacturaVentaService(ConfigConnection.connectionstring);
            InitializeComponent();
            cotizaciones = new List<FacturaCotizacion>();
            ventas = new List<FacturaVenta>();
            
        }
        
        private void BtmBuscarReportes_Click(object sender, EventArgs e)
        {

            txtCountCotizacion.Text = Convert.ToString(Cotizacionservice.ContarCotizacion());
            txtSumCotizacion.Text = Convert.ToString(Cotizacionservice.SumarCotizacion());
            txtCountVenta.Text = Convert.ToString(VentaService.ContarVentas());
            txtSumVentas.Text = Convert.ToString(VentaService.SumarVentas());
            ConsultaRespuesta response;
            if (cmbFiltro.Text.Equals(""))
            {
                MessageBox.Show("Debes elegir un tipo de filtro", "", MessageBoxButtons.OK);
            }
            else if (cmbFiltro.Text.Equals("Cotizaciones"))
            {
                dgvReportes.DataSource = null;
                response = Cotizacionservice.ConsultaFecha(dtpFechaReporte.Value);
                cotizaciones = response.Cotizaciones.ToList();
                dgvReportes.DataSource = response.Cotizaciones;
                MessageBox.Show(response.Mensaje, "", MessageBoxButtons.OK);
            }
            else if (cmbFiltro.Text.Equals("Ventas"))
            {
                dgvReportes.DataSource = null;
                response = VentaService.ConsultaFecha(dtpFechaReporte.Value);
                ventas = response.Ventas.ToList();
                dgvReportes.DataSource = response.Ventas;
                MessageBox.Show(response.Mensaje, "", MessageBoxButtons.OK);
            }



        }
    }
}
