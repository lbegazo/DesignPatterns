using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConexionOracle: Conexion
    {
        public override string obtenerConexion()
        {
            return "conexion Oracle";
        }
    }
}
