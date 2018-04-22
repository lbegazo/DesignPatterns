using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConexionSqlServer:Conexion
    {
        public override string obtenerConexion()
        {
            return "Conexion Sql Server";
        }
    }
}
