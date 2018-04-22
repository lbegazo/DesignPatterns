using AbstractFactory;
using System;

namespace DesignPatternMain
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fabrica

            //string tipoConexion=Console.ReadLine();
            //Fabrica fabrica = new Fabrica(tipoConexion);
            //Conexion conexion = fabrica.crearConexion();

            //Console.WriteLine("From " +conexion.obtenerConexion());
            //Console.ReadKey();

            #endregion Fabrica

            #region Fabrica Abstracta

            string tipoConexion = Console.ReadLine();
            FabricaHeredada fabrica = new FabricaHeredada();
            Conexion conexion = fabrica.CrearConexion(tipoConexion);

            Console.WriteLine("From " + conexion.obtenerConexion());
            Console.ReadKey();

            #endregion Fabrica Abstracta
        }
    }
}