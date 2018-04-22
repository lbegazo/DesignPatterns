using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Conexion
    {
        public virtual string obtenerConexion()
        {
            return "conexion generica";
        }
    }
}
