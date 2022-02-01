using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public abstract class DetalleFactura
    {
        public int IdFactura { get; set; }
        public Factura Factura { get; set; }
        public int CodigoDetalleFactura { get; set; }
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string Presentacion { get; set; }
        public Producto Producto { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal ValorTotal { get; set; }
        public DetalleFactura()
        {

        }
        public DetalleFactura(Producto producto, int cantidad)
        {

        }
        public  void ObtenerDetalleFactura(Producto producto, int cantidad)
        {
            IdProducto = producto.CodigoProducto;
            CostoProducto = producto.Costo;
            PrecioUnitario = producto.PrecioUnitario;
            Cantidad = cantidad;
            DescripcionProducto = producto.Nombre;
            CategoriaProducto = producto.Catergoria;
            Presentacion = producto.Presentacion;
            CalcularValorTotal();
        }
        public abstract void CalcularValorTotal();
        public abstract override string ToString();
    }
}
