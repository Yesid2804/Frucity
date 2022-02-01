using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class FacturaVenta: Factura
    {
        Producto Producto = new Producto();
        public FacturaVenta()
        {
        }
        public FacturaVenta(Persona persona)
        {
            NIT = persona.NIT;
        }
        public override void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFactura detallefacturaVenta = new DetalleVenta(producto, cantidad);
            Detalles.Add(detallefacturaVenta);
            this.Producto.DescontarInventario(cantidad);
        }

        public override List<DetalleFactura> ObtenerLista()
        {
            throw new NotImplementedException();
        }
    }
}
