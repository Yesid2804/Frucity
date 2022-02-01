using BLL;
using DAL;
using Entity;
using NUnit.Framework;
using System;

namespace TestFrucity
{
    public class Tests
    {
        static string _conexion = "Server=.; Database=Frucity_Proyecto; Trusted_Connection= True; MultipleActiveResultSets=True;";
        ClienteService serviceCliente = new ClienteService(_conexion);
        ProveedorService serviceProveedor = new ProveedorService(_conexion);
        ProductoService serviceProducto = new ProductoService(_conexion);
        FacturaCotizacionService serviceCotizacion = new FacturaCotizacionService(_conexion);
        DetalleCotizacionService serviceDetalleCotizacion = new DetalleCotizacionService(_conexion);
        //"Server=.; Database=Frucity_Proyecto; Trusted_Connection= True; MultipleActiveResultSets=True;"

        [SetUp]
        public void Setup()
        {
        }

        #region Cliente
        [Test]
        public void TestRegistroCliente()
        {

            Cliente cliente = new Cliente();
            cliente.NIT = "1002424";
            cliente.Nombre = "Carlitos";
            cliente.Direccion = "calle 3a #41";
            cliente.Telefono = "3217306758";

            string resultado = serviceCliente.Guardar(cliente);
            Assert.AreEqual(resultado, "Se guardaron los datos satisfactoriamente");
        }

        [Test]
        public void TestConsultaCliente()
        {
           
            ConsultaRespuesta result = serviceCliente.ConsultarTodos();
            Assert.AreEqual(result.Mensaje, "Consulta realizada");
        }

        [Test]
        public void TestConsultaCodigoCliente()
        {

            ConsultaRespuesta result = serviceCliente.ConsultaCodigo("32");
            Assert.AreEqual(result.Mensaje, "Consulta exitosa!!");
        }

        #endregion

        #region Proveedor
        [Test]
        public void TestRegistroProveedor()
        {

            Proveedor proveedor = new Proveedor();
            proveedor.NIT = "1003";
            proveedor.Nombre = "Andres Cordoba";
            proveedor.Direccion = "calle 4a#11";
            proveedor.Telefono = "312889341";
            proveedor.RazonSocial = "Lo mejor do mundo";

            string resultado = serviceProveedor.Guardar(proveedor);
            Assert.AreEqual(resultado, "Se guardaron los datos satisfactoriamente");
        }

        [Test]
        public void TestConsultaProveedor()
        {

            ConsultaRespuesta result = serviceProveedor.ConsultarTodos();
            Assert.AreEqual(result.Mensaje, "Consulta realizada");
        }

        #endregion

        #region Producto
        [Test]
        public void TestRegistroProducto()
        {

            Producto producto = new Producto();
            producto.CodProveedor = "1004";
            producto.Nombre = "Nectar de pera";
            producto.Cantidad = 31;
            producto.Costo = 3400;
            producto.PrecioUnitario = 1050;
            producto.Presentacion = "Mejor nectar de pera";
            producto.Catergoria = "Nectar";

            string resultado = serviceProducto.Guardar(producto);
            Assert.AreEqual(resultado, "Se guardaron los datos satisfactoriamente");
        }

        [Test]
        public void TestConsultaProducto()
        {
            ConsultaRespuesta result = serviceProducto.ConsultarTodos();
            Assert.AreEqual(result.Mensaje, "Consulta realizada");
        }
        #endregion

        #region Cotizacion
        [Test]
        public void TestRegistroCotizacion()
        {
            FacturaCotizacion cotizacion = new FacturaCotizacion();
            cotizacion.Total = 250000;
            cotizacion.FechaExpedicion = DateTime.Parse("2021-10-20");
            cotizacion.NIT = "1004"; 
            
            string resultado = serviceCotizacion.GuardarFactura(cotizacion);
            Assert.AreEqual(resultado, "OK");
        }
        [Test]
        public void TestConsultaCotizacion()
        {
            ConsultaRespuesta result = serviceCotizacion.ConsultarTodos();
            Assert.AreEqual(result.Mensaje, "Consulta realizada");
        }

        [Test]
        public void GuardarDetalle( )
        {
            Producto producto = new Producto();
            producto.CodProveedor = "1004";
            producto.Nombre = "Zumo de naranja";
            producto.Cantidad = 11;
            producto.Costo = 33400;
            producto.PrecioUnitario = 41050;
            producto.Presentacion = "Mejor zumo de naranja de la region";
            producto.Catergoria = "Zumo";
            
            DetalleCotizacion detallecotizacion = new DetalleCotizacion(producto,3);
            string result = serviceDetalleCotizacion.GuardarDetalle(detallecotizacion);
        }
        #endregion
    }
}