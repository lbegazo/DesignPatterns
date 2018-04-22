using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConexionGenerica: Conexion
    {
        public override string obtenerConexion()
        {
            return "Conexion generica";
        }
    }
}
