using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FabricaHeredada : FabricaAbstracta
    {
        public override Conexion CrearConexion(string tipo)
        {
            switch (tipo)
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
