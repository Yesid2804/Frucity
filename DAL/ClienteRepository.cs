using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ClienteRepository
    {
        private SqlConnection conexion;

        public ClienteRepository(ConnectionManager connection)
        {
           conexion = connection._conexion;
        }

        public void Guardar(Cliente cliente)
        {
            using (SqlCommand sqlcommand = conexion.CreateCommand())
            {
                sqlcommand.CommandText = "insert into Cliente(CodCliente,Nombre,Direccion,Telefono) " +
                    "values (@CodCliente,@Nombre,@Direccion,@Telefono)";
                sqlcommand.Parameters.AddWithValue("@CodCliente", cliente.NIT);
                sqlcommand.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                sqlcommand.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                sqlcommand.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                sqlcommand.ExecuteNonQuery();
            }
        }
        public List<Cliente> ConsultarTodo()
        {
            SqlDataReader dataReader;
            List<Cliente> Clientes = new List<Cliente>();
            using (SqlCommand command = conexion.CreateCommand())
            {
                command.CommandText = "select * from Cliente";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = Mapear(dataReader);
                        Clientes.Add(cliente);
                    }
                }
            }
            return Clientes;
        }

        private Cliente Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.NIT = (string)dataReader["CodCliente"];
            cliente.Nombre = (string)dataReader["Nombre"];
            cliente.Direccion = (string)dataReader["Direccion"];
            cliente.Telefono = (string)dataReader["Telefono"];
            return cliente;
        }

        public IList<Cliente> ConsultarCodigo(string cod)
        {
            //return ConsultarTodo().Where(C => C.NIT.Equals(cod)).ToList();
            return ConsultarTodo().Where(C => C.NIT.Contains(cod)).ToList();
        }
        public IList<Cliente> ConsultarNombre(string nombre)
        {
            return ConsultarTodo().Where(C => C.Nombre.Contains(nombre)).ToList();
        }
    }
}
