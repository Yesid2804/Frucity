using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteService
    {
        private ConnectionManager connection;
        private ClienteRepository repository;
        public ClienteService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new ClienteRepository(connection);
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                connection.Open();
                if (repository.ConsultarCodigo(cliente.NIT).Count() == 0 )
                {
                    repository.Guardar(cliente);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"El proveedor ya existe";

            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally { connection.Close(); }
        }
        public ConsultaRespuesta ConsultarTodos()
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Clientes = repository.ConsultarTodo();
                connection.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Clientes.Count > 0) ? "Consulta realizada" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { connection.Close(); }
        }
        public ConsultaRespuesta ConsultaCodigo(string codigo)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Clientes = repository.ConsultarCodigo(codigo);
                connection.Close();
                respuesta.Mensaje = (respuesta.Clientes != null) ? "Consulta exitosa!!" : "Consulta erronea.";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { connection.Close(); }
        }
        public ConsultaRespuesta ConsultaNombre(string nombre)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Clientes = repository.ConsultarNombre(nombre);
                connection.Close();
                respuesta.Mensaje = (respuesta.Clientes != null) ? "Consulta exitosa!!" : "Consulta erronea.";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { connection.Close(); }
        }
    }
}
