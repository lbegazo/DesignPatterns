﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConexionGenerica: Conexion
    {
        public override string obtenerConexion()
        {
            return "Conexion generica";
        }
    }
}
