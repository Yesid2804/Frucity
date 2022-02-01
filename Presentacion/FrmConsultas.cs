using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entity;
using BLL;
using System.Linq;

namespace Presentacion
{
    public partial class FrmConsultas : Form
    {
        ProveedorService proveedorServices;
        ClienteService clienteService;
        List<Proveedor> proveedores;
        List<Cliente> clientes;
        public FrmConsultas()
        {
            proveedorServices = new ProveedorService(ConfigConnection.connectionstring);
            clienteService = new ClienteService(ConfigConnection.connectionstring);
            InitializeComponent();
            proveedores = new List<Proveedor>();
            clientes = new List<Cliente>();
        }

        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            
            string tipo = cmbTipo.Text;
            string consulta = cmbCod_Name.Text;
            if (tipo.Equals("Proveedores"))
            {
                if (TxtConsulta.Text.Equals(""))
                {
                    dgvConsulta.DataSource = null;
                    respuesta = proveedorServices.ConsultarTodos();
                    proveedores = respuesta.Proveedores.ToList();
                    dgvConsulta.DataSource = respuesta.Proveedores;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (consulta.Equals("Codigo"))
                {
                    dgvConsulta.DataSource = null;
                    respuesta = proveedorServices.ConsultaCodigo(TxtConsulta.Text);
                    dgvConsulta.DataSource = respuesta.Proveedores;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvConsulta.DataSource = null;
                    respuesta = proveedorServices.ConsultaNombre(TxtConsulta.Text);
                    dgvConsulta.DataSource = respuesta.Proveedores;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (tipo.Equals("Clientes"))
            {
                if (TxtConsulta.Text.Equals(""))
                {
                    dgvConsulta.DataSource = null;
                    respuesta = clienteService.ConsultarTodos();
                    clientes = respuesta.Clientes.ToList();
                    dgvConsulta.DataSource = respuesta.Clientes;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (consulta.Equals("Codigo"))
                {
                    dgvConsulta.DataSource = null;
                    respuesta = clienteService.ConsultaCodigo(TxtConsulta.Text);
                    dgvConsulta.DataSource = respuesta.Clientes;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvConsulta.DataSource = null;
                    respuesta = clienteService.ConsultaNombre(TxtConsulta.Text);
                    dgvConsulta.DataSource = respuesta.Clientes;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de filtro", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        
    }
}
