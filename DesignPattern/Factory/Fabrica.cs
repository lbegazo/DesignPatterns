using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Fabrica
    {
        protected string _tipo;

        public Fabrica(string t)
        {
            _tipo = t;
        }

        public Conexion crearConexion() {

            switch (_tipo)
            {
                case "Oracle":
                    return new ConexionOracle();
                case "Sql":
                    return new ConexionSqlServer();
                case "mySql":
                    return new ConexionMySql();
                default:
                    return new ConexionGenerica();
            }
        }
    }
}
