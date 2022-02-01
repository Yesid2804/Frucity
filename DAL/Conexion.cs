using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace Entity
{
    class Conexion
    {
        String cn = "Data Source=DESKTOP-IT5O6K8\\SQLEXPRESS01;Initial Catalog=Frucity_Proyecto;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public Conexion()
        {
            conectarbd.ConnectionString = cn;
        }
            
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al abrir la BD  " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
