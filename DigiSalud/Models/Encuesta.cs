using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiSalud.Models
{
    public class Encuesta
    {
        //Datos de concentimiento
        public bool FormatoEnPapel { get; set; }
        public bool PartiCipa { get; set; }

        //Datos sociodemográficos
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadActual { get; set; }
        public bool Retraso { get; set; }
        public int SemestresAtrasados { get; set; }

        //Motivos de atraso
        public bool Dificultades { get; set; }
        public bool ProblemasEcon { get; set; }
        public bool ProblemasSalud { get; set; }
        public bool ProblemasSaludMen { get; set; }
        public bool ProblemasFamil { get; set; }
        public bool CalamidadDomes { get; set; }

        //Porcion de actividades
        public int Estudio { get; set; }
        public int Deporte { get; set; }
        public int Culturales { get; set; }
        public int Entretenimiento { get; set; }
        public int Trabajo { get; set; }
        public int Religiosas { get; set; }
        public int Otras { get; set; }
        public bool CondicionMedica{ get; set; }
        public string CondicionMedicaDet { get; set; }

        //Condiciones medeicas Familiares
        public string[][] matrizFamiliares { get; set; }

        //Sustancias
        public int Alcohol { get; set; }
        public int Nicotina { get; set; }
        public int Cannabis { get; set; }
        public int Cocaina { get; set; }
        public int Sedantes { get; set; }
        public int Opiaceos { get; set; }
        public int Otros { get; set; }

        //Uso de internet
        public bool LoUsa { get; set; }

        //Dispositivos
        public bool SmarthPhone { get; set; }
        public bool Tablet { get; set; }
        public bool ComputadorFamiliar { get; set; }
        public bool ComputadorPropio { get; set; }
        public bool PortatilFamiliar { get; set; }
        public bool PortatilPropio { get; set; }
        public bool TV { get; set; }
        public bool Consola { get; set; }

        //Lugares de acceso
        public bool SalaHogar { get; set; }
        public bool Habitacion { get; set; }
        public bool Universidad { get; set; }
        public bool TrabajoI { get; set; }
        public bool CasaAmigo { get; set; }
        public bool CasaFamiliar { get; set; }
        public bool OtrosPublicos { get; set; }
        public bool OtraVia { get; set; }

        //Información de acceso
        public bool InternetCasa { get; set; }
        public bool InternetMobil { get; set; }
        public bool InternetTrabajo { get; set; }
        public bool InternetUniversidad { get; set; }
        public bool InternetPublico { get; set; }
    }
}