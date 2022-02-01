    using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Proveedor: Persona
    {
        public string RazonSocial { get; set; }
        public Proveedor()
        {
        }
        public Proveedor(string nit, string nombre, string direccion, string telefono, string razonSocial) : base(nit, nombre, direccion, telefono)
        {
            RazonSocial = razonSocial;
        }
        public override string ToString()
        {
            return $"{NIT};{Nombre};{Direccion};{Telefono};{RazonSocial}";
        }
    }
}
