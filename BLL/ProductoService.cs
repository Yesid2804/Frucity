using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BLL
{
    public class ProductoService
    {
        private ConnectionManager connection;
        private ProductoRepository repository;
        public ProductoService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new ProductoRepository(connection);
        }
        public string Guardar(Producto producto)
        {
            try
            {
                string productoString = Convert.ToString(producto.Nombre);
                connection.Open();
                if (repository.ConsultarNombre(productoString).Count()==0)
                {
                    repository.Guardar(producto);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"El producto ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally { connection.Close(); }
        }
        public Producto Verificar(int cod)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                return repository.VerificarExistencia(cod);
            }
            finally { connection.Close(); }
        }
        public ConsultaRespuesta ConsultarTodos()
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Productos = repository.ConsultarTodo();
                connection.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Consulta realizada" : "No hay datos para consultar";
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
        public ConsultaRespuesta ConsultaProductosProveedor(string proveedor, string producto)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Productos = repository.ConsultaProductosProveedor(proveedor,producto);
                connection.Close();
                respuesta.Mensaje = (respuesta.Proveedores == null) ? "Consulta exitosa!!" : "Consulta erronea.";
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
        public ConsultaRespuesta ConsultaCodigo(string codigo)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Productos = repository.ConsultarCodigo(codigo);
                connection.Close();
                respuesta.Mensaje = (respuesta.Proveedores == null) ? "Consulta exitosa!!" : "Consulta erronea.";
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
                respuesta.Productos = repository.ConsultarNombre(nombre);
                connection.Close();
                respuesta.Mensaje = (respuesta.Proveedores == null) ? "Consulta exitosa!!" : "Consulta erronea.";
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
        public ConsultaRespuesta ConsultaCategoria(string categoria)
        {
            ConsultaRespuesta respuesta = new ConsultaRespuesta();
            try
            {
                connection.Open();
                respuesta.Productos = repository.ConsultarCategoria(categoria);
                connection.Close();
                respuesta.Mensaje = (respuesta.Proveedores == null) ? "Consulta exitosa!!" : "Consulta erronea.";
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
