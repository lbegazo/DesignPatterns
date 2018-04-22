using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConexionMySql: Conexion    
    {
        public override string obtenerConexion()
        {
            return "Conexion mySql";
        }

    }
}
