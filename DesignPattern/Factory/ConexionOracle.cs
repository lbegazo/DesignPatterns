﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConexionOracle: Conexion
    {
        public override string obtenerConexion()
        {
            return "conexion Oracle";
        }
    }
}
