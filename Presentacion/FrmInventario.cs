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
    public partial class FrmInventario : Form
    {
        ProductoService services;
        List<Producto> productos;
        public FrmInventario()
        {
            services = new ProductoService(ConfigConnection.connectionstring);
            InitializeComponent();
            productos = new List<Producto>();
            cmbCategoria.Enabled = false;

        }

        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            string tipo = cmbTipo.Text;
            string categoria = cmbCategoria.Text;

            if (tipo.Equals("Codigo"))
            {
                if (txtInventario.Text.Equals(""))
                {
                    MessageBox.Show("Dede ingresar valores para realizar la consulta", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvInventario.DataSource = null;
                    respuesta = services.ConsultaCodigo(txtInventario.Text);
                    dgvInventario.DataSource = respuesta.Productos;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else if(tipo.Equals("Nombre"))
            {
                if (txtInventario.Text.Equals(""))
                {
                    MessageBox.Show("Dede ingresar valores para realizar la consulta", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvInventario.DataSource = null;
                    respuesta = services.ConsultaNombre(txtInventario.Text);
                    dgvInventario.DataSource = respuesta.Productos;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (tipo.Equals("Categoria"))
            {
                
                if (cmbCategoria.Text.Equals(""))
                {
                    MessageBox.Show("Dede elegir la cantegoria para consultarlo", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvInventario.DataSource = null;
                    respuesta = services.ConsultaCategoria(categoria);
                    dgvInventario.DataSource = respuesta.Productos;
                    //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(tipo.Equals("Todo"))
            {
                dgvInventario.DataSource = null;
                respuesta = services.ConsultarTodos();
                productos = respuesta.Productos.ToList();
                dgvInventario.DataSource = respuesta.Productos;
                //MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dede elegir el filtro para consultarlo", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text.Equals("Categoria"))
            {
                cmbCategoria.Enabled = true;
            }
            else
            {
                cmbCategoria.Enabled = false;
            }
        }




    }
}
