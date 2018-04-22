using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Conexion
    {
        public virtual string obtenerConexion()
        {
            return "conexion generica";
        }
    }
}
