using edu.PR.SIMULACRO.Controladores;
using edu.PR.SIMULACRO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.SIMULACRO.Servicios
{
    internal class OperativaImplementacion
    {
        public void agregarVehiculo()
        {
            
            Console.WriteLine("Introduzca la matricula del vehiculo");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduzca Tipo de vehiculo");
            char tipoVehiculo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("¿El vehiculo lleva mercancia?: s/n");
            bool llevaMercancia = Convert.ToBoolean(Console.ReadLine());

            VehiculosDto nuevoVehiculo = new VehiculosDto(matricula,tipoVehiculo, llevaMercancia);

            if (llevaMercancia.Equals("s") ) { 
                 nuevoVehiculo.LlevaMercancia = true;          
            }
                     
        }



        public void validarEntradaPuerto(List<VehiculosDto> lista)
        {

            MenuInterfaz mi = new MenuImplementacion();

            Console.WriteLine("Introduce la matricula del vehiculo");
            string matriculaRevision = Console.ReadLine();

            for(int i = 0; i < lista.Count; i++)
            {
                VehiculosDto vehiculo = lista[i];

                if (matriculaRevision.Equals(vehiculo.Matricula))
                {
                    if (vehiculo.TipoVehiculo.Equals("P"))
                    {
                        Console.WriteLine("Estas en puerto SO");
                        vehiculo.ZonaDestino = "SO";
                        Program.listaPuertaSE.Add(vehiculo.Matricula);
                    }


                    else if (vehiculo.TipoVehiculo.Equals("F") | vehiculo.TipoVehiculo.Equals("A"))
                    {
                        vehiculo.ZonaDestino = "Se";
                        vehiculo.FechaPasoSE = new DateTime();

                        Program.listaPuertaSE.Add(vehiculo.Matricula);
                        


                    }



                    else if(vehiculo.TipoVehiculo.Equals("F") | vehiculo.TipoVehiculo.Equals("A") & vehiculo.LlevaMercancia == true)
                    {
                        Console.WriteLine("Estas en puerto SN");
                        vehiculo.ZonaDestino = "SN";
                    }

                }
            }

        }


    }
}
