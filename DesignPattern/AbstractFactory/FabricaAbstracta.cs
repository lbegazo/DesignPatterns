using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class FabricaAbstracta
    {
        public abstract Conexion CrearConexion(string tipo);

    }
}
