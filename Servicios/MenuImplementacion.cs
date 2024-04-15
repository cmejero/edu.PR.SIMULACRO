using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.SIMULACRO.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccionPrincipal()
        {
            int opcionUsuario;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Cerrar Aplicacion");
            Console.WriteLine("1. Introducir Vehiculo");
            Console.WriteLine("1. Ir al puerto");
            Console.WriteLine("#########################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public int menuYSeleccionSO()
        {
            int opcionUsuario;
            Console.WriteLine("##########################");
            Console.WriteLine("0. Retroceder");
            Console.WriteLine("1. Acceder a puerto SO");
            Console.WriteLine("##########################");
            opcionUsuario= Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public int menuYSeleccionSE()
        {
            int opcionUsuario;
            Console.WriteLine("##########################");
            Console.WriteLine("0. Retroceder");
            Console.WriteLine("1. Acceder a puerto SE");
            Console.WriteLine("##########################");
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public int menuYSeleccionEN()
        {
            int opcionUsuario;
            Console.WriteLine("##########################");
            Console.WriteLine("0. Retroceder");
            Console.WriteLine("1. Acceder a puerto EN");
            Console.WriteLine("##########################");
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public int menuYSeleccionSN()
        {
            int opcionUsuario;
            Console.WriteLine("##########################");
            Console.WriteLine("0. Retroceder");
            Console.WriteLine("1. Acceder a puerto SN");
            Console.WriteLine("##########################");
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }










    }
}
