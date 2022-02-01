using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        FrmPrincipal frmppal = new FrmPrincipal();
        FrmInicio inicio = new FrmInicio();
        public int cont { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void BtmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtmMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals("Contraseña"))
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(""))
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        public void IniciarSesion()
        {
            Conexion conexion = new Conexion();
            conexion.abrir();
            MessageBox.Show("AAAAAAA");
            if (cont < 3)
            {
                if (txtUsuario.Text.Equals("admi") && txtContraseña.Text.Equals("12345"))
                {
                    cont = 0;
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    cont += 1;
                    MessageBox.Show("Usuario o contraseña incorrecto", "¿Olvidaste tu contraseña?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Si tienes problemas con el inicio de sesion comunicate con los desarrolladores", "¿Problemas al iniciar sesion?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void BtmIngresar_Click(object sender, EventArgs e)
        {
            
            IniciarSesion();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Aqui");
            //Conexion conexion = new Conexion();
            //conexion.abrir();
        }
    }
}
