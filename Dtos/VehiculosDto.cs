using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.SIMULACRO.Dtos
{
    internal class VehiculosDto
    {
        string matricula;
        Char tipoVehiculo;
        string zonaDestino;
        bool llevaMercancia = false;
        DateTime controlDePrecision;
        DateTime ordenLlegada;
        DateTime fechaPasoS;
        DateTime fechaPasoSE;
        DateTime fechaPasoSN;
        DateTime fechaPasoSO;
        DateTime fechaPasoPIF;
        DateTime fechaPasoEN;

        

        public VehiculosDto()
        {
        }

        public VehiculosDto(string matricula, char tipoVehiculo, bool llevaMercancia )
        {
            this.matricula = matricula;
            this.tipoVehiculo = tipoVehiculo;
            this.zonaDestino = zonaDestino;
            this.llevaMercancia = llevaMercancia;
            this.controlDePrecision = controlDePrecision;
            this.ordenLlegada = ordenLlegada;
            this.fechaPasoS = fechaPasoS;
            this.fechaPasoSE = fechaPasoSE;
            this.fechaPasoSN = fechaPasoSN;
            this.fechaPasoSO = fechaPasoSO;
            this.fechaPasoPIF = fechaPasoPIF;
            this.fechaPasoEN = fechaPasoEN;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public char TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public bool LlevaMercancia { get => llevaMercancia; set => llevaMercancia = value; }
        public DateTime ControlDePrecision { get => controlDePrecision; set => controlDePrecision = value; }
        public DateTime OrdenLlegada { get => ordenLlegada; set => ordenLlegada = value; }
        public DateTime FechaPasoS { get => fechaPasoS; set => fechaPasoS = value; }
        public DateTime FechaPasoSE { get => fechaPasoSE; set => fechaPasoSE = value; }
        public DateTime FechaPasoSN { get => fechaPasoSN; set => fechaPasoSN = value; }
        public DateTime FechaPasoSO { get => fechaPasoSO; set => fechaPasoSO = value; }
        public DateTime FechaPasoPIF { get => fechaPasoPIF; set => fechaPasoPIF = value; }
        public DateTime FechaPasoEN { get => fechaPasoEN; set => fechaPasoEN = value; }
    }

}
