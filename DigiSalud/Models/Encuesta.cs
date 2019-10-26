using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiSalud.Models
{
    public class Encuesta
    {
        //Datos de concentimiento
        public string FormatoEnPapel { get; set; }
        public string PartiCipa { get; set; }

        //Datos sociodemográficos
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadActual { get; set; }
        public string Retraso { get; set; }
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

        //
        public string CondicionMedica { get; set; }
        public string CondicionMedicaDet { get; set; }

        //Condiciones medeicas Familiares
        //Enfermedades mentales
        public bool MadreEnfMen { get; set; }
        public bool PadreEnfMen { get; set; }
        public bool HermanoEnfMen { get; set; }
        public bool ParejaEnfMen { get; set; }
        public bool AbueloEnfMen { get; set; }
        public bool PrimoEnfMen { get; set; }
        public bool SobrinoEnfMen { get; set; }
        public bool HijoEnfMen { get; set; }
        public bool TioEnfMen { get; set; }

        //Depresion
        public bool MadreDep { get; set; }
        public bool PadreDep { get; set; }
        public bool HermanoDep { get; set; }
        public bool ParejaDep { get; set; }
        public bool AbueloDep { get; set; }
        public bool PrimoDep { get; set; }
        public bool SobrinoDep { get; set; }
        public bool HijoEnfDep { get; set; }
        public bool TioEnfDep { get; set; }

        //Ansiedad

        public bool MadreAns { get; set; }
        public bool PadreAns { get; set; }
        public bool HermanoAns { get; set; }
        public bool ParejaAns { get; set; }
        public bool AbueloAns { get; set; }
        public bool PrimoAns { get; set; }
        public bool SobrinoAns { get; set; }
        public bool HijoEnfAns { get; set; }
        public bool TioEnfAns { get; set; }

        //Esquizofrenia o psicosis

        public bool MadreEsq { get; set; }
        public bool PadreEsq { get; set; }
        public bool HermanoEsq { get; set; }
        public bool ParejaEsq { get; set; }
        public bool AbueloEsq { get; set; }
        public bool PrimoEsq { get; set; }
        public bool SobrinoEsq { get; set; }
        public bool HijoEnfEsq { get; set; }
        public bool TioEnfEsq { get; set; }

        //Consumo de licor o drogas
        public bool MadreLicDrog { get; set; }
        public bool PadreLicDrog { get; set; }
        public bool HermanoLicDrog { get; set; }
        public bool ParejaLicDrog { get; set; }
        public bool AbueloLicDrog { get; set; }
        public bool PrimoLicDrog { get; set; }
        public bool SobrinoLicDrog { get; set; }
        public bool HijoEnfLicDrog { get; set; }
        public bool TioEnfLicDrog { get; set; }

        //Otra enfermedad mental
        public bool MadreOtra { get; set; }
        public bool PadreOtra { get; set; }
        public bool HermanoOtra { get; set; }
        public bool ParejaOtra { get; set; }
        public bool AbueloOtra { get; set; }
        public bool PrimoOtra { get; set; }
        public bool SobrinoOtra { get; set; }
        public bool HijoEnfOtra { get; set; }
        public bool TioEnfOtra { get; set; }

        //Tiempo de diagnóstico
        public int MadreTiempoD { get; set; }
        public int PadreTiempoD { get; set; }
        public int HermanoTiempoD { get; set; }
        public int ParejaTiempoD { get; set; }
        public int AbueloTiempoD { get; set; }
        public int PrimoTiempoD { get; set; }
        public int SobrinoTiempoD { get; set; }
        public int HijoEnfTiempoD { get; set; }
        public int TioEnfTiempoD { get; set; }

        //Se encuentra en tratamiento?
        public bool MadreTrat { get; set; }
        public bool PadreTrat { get; set; }
        public bool HermanoTrat { get; set; }
        public bool ParejaTrat { get; set; }
        public bool AbueloTrat { get; set; }
        public bool PrimoTrat { get; set; }
        public bool SobrinoTrat { get; set; }
        public bool HijoEnfTrat { get; set; }
        public bool TioEnfTrat { get; set; }
        //Sustancias
        public string Alcohol { get; set; }
        public string Nicotina { get; set; }
        public string Cannabis { get; set; }
        public string Cocaina { get; set; }
        public string Sedantes { get; set; }
        public string Opiaceos { get; set; }
        public string Otros { get; set; }

        //Uso de internet
        public string LoUsa { get; set; }

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