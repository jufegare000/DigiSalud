//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigiSalud.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class encuesta
    {
        public int id { get; set; }
        public string FormatoEnPapel { get; set; }
        public string PartiCipa { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Sexo { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadActual { get; set; }
        public string Retraso { get; set; }
        public Nullable<int> SemestresAtrasados { get; set; }
        public Nullable<bool> Dificultades { get; set; }
        public Nullable<bool> ProblemasEcon { get; set; }
        public Nullable<bool> ProblemasSalud { get; set; }
        public Nullable<bool> ProblemasSaludMen { get; set; }
        public Nullable<bool> ProblemasFamil { get; set; }
        public Nullable<bool> CalamidadDomes { get; set; }
        public Nullable<int> Estudio { get; set; }
        public Nullable<int> Deporte { get; set; }
        public Nullable<int> Culturales { get; set; }
        public Nullable<int> Entretenimiento { get; set; }
        public Nullable<int> Trabajo { get; set; }
        public Nullable<int> Religiosas { get; set; }
        public Nullable<int> Otras { get; set; }
        public string CondicionMedica { get; set; }
        public string CondicionMedicaDet { get; set; }
        public Nullable<bool> MadreEnfMen { get; set; }
        public Nullable<bool> PadreEnfMen { get; set; }
        public Nullable<bool> HermanoEnfMen { get; set; }
        public Nullable<bool> ParejaEnfMen { get; set; }
        public Nullable<bool> AbueloEnfMen { get; set; }
        public Nullable<bool> PrimoEnfMen { get; set; }
        public Nullable<bool> SobrinoEnfMen { get; set; }
        public Nullable<bool> HijoEnfMen { get; set; }
        public Nullable<bool> TioEnfMen { get; set; }
        public Nullable<bool> MadreDep { get; set; }
        public Nullable<bool> PadreDep { get; set; }
        public Nullable<bool> HermanoDep { get; set; }
        public Nullable<bool> ParejaDep { get; set; }
        public Nullable<bool> AbueloDep { get; set; }
        public Nullable<bool> PrimoDep { get; set; }
        public Nullable<bool> SobrinoDep { get; set; }
        public Nullable<bool> HijoEnfDep { get; set; }
        public Nullable<bool> TioEnfDep { get; set; }
        public Nullable<bool> MadreAns { get; set; }
        public Nullable<bool> PadreAns { get; set; }
        public Nullable<bool> HermanoAns { get; set; }
        public Nullable<bool> ParejaAns { get; set; }
        public Nullable<bool> AbueloAns { get; set; }
        public Nullable<bool> PrimoAns { get; set; }
        public Nullable<bool> SobrinoAns { get; set; }
        public Nullable<bool> HijoEnfAns { get; set; }
        public Nullable<bool> TioEnfAns { get; set; }
        public Nullable<bool> MadreEsq { get; set; }
        public Nullable<bool> PadreEsq { get; set; }
        public Nullable<bool> HermanoEsq { get; set; }
        public Nullable<bool> ParejaEsq { get; set; }
        public Nullable<bool> AbueloEsq { get; set; }
        public Nullable<bool> PrimoEsq { get; set; }
        public Nullable<bool> SobrinoEsq { get; set; }
        public Nullable<bool> HijoEnfEsq { get; set; }
        public Nullable<bool> TioEnfEsq { get; set; }
        public Nullable<bool> MadreLicDrog { get; set; }
        public Nullable<bool> PadreLicDrog { get; set; }
        public Nullable<bool> HermanoLicDrog { get; set; }
        public Nullable<bool> ParejaLicDrog { get; set; }
        public Nullable<bool> AbueloLicDrog { get; set; }
        public Nullable<bool> PrimoLicDrog { get; set; }
        public Nullable<bool> SobrinoLicDrog { get; set; }
        public Nullable<bool> HijoEnfLicDrog { get; set; }
        public Nullable<bool> TioEnfLicDrog { get; set; }
        public Nullable<bool> MadreOtra { get; set; }
        public Nullable<bool> PadreOtra { get; set; }
        public Nullable<bool> HermanoOtra { get; set; }
        public Nullable<bool> ParejaOtra { get; set; }
        public Nullable<bool> AbueloOtra { get; set; }
        public Nullable<bool> PrimoOtra { get; set; }
        public Nullable<bool> SobrinoOtra { get; set; }
        public Nullable<bool> HijoEnfOtra { get; set; }
        public Nullable<bool> TioEnfOtra { get; set; }
        public string MadreTiempoD { get; set; }
        public string PadreTiempoD { get; set; }
        public string HermanoTiempoD { get; set; }
        public string ParejaTiempoD { get; set; }
        public string AbueloTiempoD { get; set; }
        public string PrimoTiempoD { get; set; }
        public string SobrinoTiempoD { get; set; }
        public string HijoEnfTiempoD { get; set; }
        public string TioEnfTiempoD { get; set; }
        public Nullable<bool> MadreTrat { get; set; }
        public Nullable<bool> PadreTrat { get; set; }
        public Nullable<bool> HermanoTrat { get; set; }
        public Nullable<bool> ParejaTrat { get; set; }
        public Nullable<bool> AbueloTrat { get; set; }
        public Nullable<bool> PrimoTrat { get; set; }
        public Nullable<bool> SobrinoTrat { get; set; }
        public Nullable<bool> HijoTrat { get; set; }
        public Nullable<bool> TioEnfTrat { get; set; }
        public string Alcohol { get; set; }
        public string Nicotina { get; set; }
        public string Cannabis { get; set; }
        public string Cocaina { get; set; }
        public string Sedantes { get; set; }
        public string Opiaceos { get; set; }
        public string Otros { get; set; }
        public string LoUsa { get; set; }
        public Nullable<bool> SmarthPhone { get; set; }
        public Nullable<bool> Tablet { get; set; }
        public Nullable<bool> ComputadorFamiliar { get; set; }
        public Nullable<bool> ComputadorPropio { get; set; }
        public Nullable<bool> PortatilFamiliar { get; set; }
        public Nullable<bool> PortatilPropio { get; set; }
        public Nullable<bool> TV { get; set; }
        public Nullable<bool> Consola { get; set; }
        public Nullable<bool> SalaHogar { get; set; }
        public Nullable<bool> Habitacion { get; set; }
        public Nullable<bool> Universidad { get; set; }
        public Nullable<bool> TrabajoI { get; set; }
        public Nullable<bool> CasaAmigo { get; set; }
        public Nullable<bool> CasaFamiliar { get; set; }
        public Nullable<bool> OtrosPublicos { get; set; }
        public Nullable<bool> OtraVia { get; set; }
        public Nullable<bool> InternetCasa { get; set; }
        public Nullable<bool> InternetMobil { get; set; }
        public Nullable<bool> InternetTrabajo { get; set; }
        public Nullable<bool> InternetUniversidad { get; set; }
        public Nullable<bool> InternetPublico { get; set; }
        public Nullable<System.DateTime> fechaDiligen { get; set; }
    }
}