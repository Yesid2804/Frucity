using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProductoRepository
    {
        private SqlConnection conexion;
        public ProductoRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public void Guardar(Producto producto)
        {
            using (SqlCommand sqlCommand = conexion.CreateCommand())
            {
                sqlCommand.CommandText = "insert into Producto (Nombre,Costo,PrecioUnitario,Presentacion,Categoria,CodProveedor,Cantidad) " +
                    "values (@Nombre,@Costo,@PrecioUnitario,@Presentacion,@Categoria,@CodProveedor,@Cantidad)";
                sqlCommand.Parameters.AddWithValue("@Nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("@Costo", producto.Costo);
                sqlCommand.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                sqlCommand.Parameters.AddWithValue("@Presentacion", producto.Presentacion);
                sqlCommand.Parameters.AddWithValue("@Categoria", producto.Catergoria);
                sqlCommand.Parameters.AddWithValue("@CodProveedor", producto.CodProveedor);
                sqlCommand.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public List<Producto> ConsultarTodo()
        {
            SqlDataReader dataReader;
            List<Producto> Productos = new List<Producto>();
            using (SqlCommand command = conexion.CreateCommand())
            {
                command.CommandText = "select * from Producto";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = Mapear(dataReader);
                        Productos.Add(producto);
                    }
                }
            }
            return Productos;
        }
        public Producto Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.CodigoProducto = (int)dataReader["CodProducto"];
            producto.Nombre = (string)dataReader["Nombre"];
            producto.Costo = (decimal)dataReader["Costo"];
            producto.PrecioUnitario = (decimal)dataReader["PrecioUnitario"];
            producto.Presentacion = (string)dataReader["Presentacion"];
            producto.Catergoria = (string)dataReader["Categoria"];
            producto.CodProveedor = (string)dataReader["CodProveedor"];
            producto.Cantidad = (int)dataReader["Cantidad"];
            return producto;
        }
        public Producto VerificarExistencia(int id)
        {
            foreach (Producto item in ConsultarTodo())
            {
                if (item.CodigoProducto.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        public IList<Producto> ConsultarCodigo(string cod)
        {
            //return ConsultarTodo().Where(P => Convert.ToString(P.CodigoProducto).Equals(cod)).ToList();
            return ConsultarTodo().Where(P => Convert.ToString(P.CodigoProducto).Contains(cod)).ToList();
        }
        public IList<Producto> ConsultaProductosProveedor(string codProveeor,string codProducto)
        {
            IList<Producto> InfoProveedor = ConsultarTodo().Where(P => Convert.ToString(P.CodProveedor).Equals(codProveeor)).ToList();
            return InfoProveedor.Where(C => Convert.ToString(C.CodigoProducto).Equals(codProducto)).ToList();
        }
        public IList<Producto> ConsultarNombre(string nombre)
        {
            return ConsultarTodo().Where(P => P.Nombre.Contains(nombre)).ToList();
        }
        public IList<Producto> ConsultarCategoria(string categoria)
        {
            return ConsultarTodo().Where(P => P.Catergoria.Contains(categoria)).ToList();
        }
    }
}
