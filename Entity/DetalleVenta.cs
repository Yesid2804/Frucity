using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DetalleVenta : DetalleFactura
    {
        public DetalleVenta()
        {

        }
        public DetalleVenta(Producto producto, int cantidad) : base(producto, cantidad)
        {
            ObtenerDetalleFactura(producto, cantidad);
            CalcularValorTotal();
        }
        public override void CalcularValorTotal()
        {
            ValorTotal = PrecioUnitario * Cantidad;
        }
        public override string ToString()
        {
            return $"{IdProducto};{DescripcionProducto};" +
                $"{CategoriaProducto};{Presentacion};{Cantidad};{PrecioUnitario};{ValorTotal}";
        }
    }
}
