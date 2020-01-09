
create database digisalud;
go;
use digisalud;
go;
create table encuesta(
	id int primary key identity,
	FormatoEnPapel varchar(2),
	PartiCipa varchar(2),
	Edad int,
	Sexo varchar(10),
	CiudadOrigen varchar(200),
	CiudadActual varchar(200),
	Retraso varchar(2),
	SemestresAtrasados int, 
	Dificultades bit,
	ProblemasEcon bit, 
	ProblemasSalud bit,
	ProblemasSaludMen bit, 
	ProblemasFamil bit, 
	CalamidadDomes bit, 
	Estudio int, 
	Deporte int, 
	Culturales int,
	Entretenimiento int, 
	Trabajo int, 
	Religiosas int,
	Otras int,
	CondicionMedica varchar(2),
	CondicionMedicaDet varchar(500),
	MadreEnfMen bit, 
	PadreEnfMen bit, 
	HermanoEnfMen bit,
	ParejaEnfMen bit,
	AbueloEnfMen bit, 
	PrimoEnfMen bit, 
	SobrinoEnfMen bit,
	HijoEnfMen bit,
	TioEnfMen bit,
	MadreDep bit,
	PadreDep bit, 
	HermanoDep bit,
	ParejaDep bit,
	AbueloDep bit,
	PrimoDep bit,
	SobrinoDep bit,
	HijoEnfDep bit,
	TioEnfDep bit,
	MadreAns bit,
	PadreAns bit,
	HermanoAns bit,
	ParejaAns bit,
	AbueloAns bit,
	PrimoAns bit,
	SobrinoAns bit,
	HijoEnfAns bit,
	TioEnfAns bit,
	MadreEsq bit,
	PadreEsq bit,
	HermanoEsq bit,
	ParejaEsq bit,
	AbueloEsq bit,
	PrimoEsq bit,
	SobrinoEsq bit,
	HijoEnfEsq bit,
	TioEnfEsq bit,
	MadreLicDrog bit,
	PadreLicDrog bit, 
	HermanoLicDrog bit,
	ParejaLicDrog bit,
	AbueloLicDrog bit,
	PrimoLicDrog bit,
	SobrinoLicDrog bit,
	HijoEnfLicDrog bit,
	TioEnfLicDrog bit,
	MadreOtra bit,
	PadreOtra bit,
	HermanoOtra bit,
	ParejaOtra bit,
	AbueloOtra bit,
	PrimoOtra bit,
	SobrinoOtra bit,
	HijoEnfOtra bit,
	TioEnfOtra bit,
	MadreTiempoD varchar(100),
	PadreTiempoD varchar(100),
	HermanoTiempoD varchar(100),
	ParejaTiempoD varchar(100),
	AbueloTiempoD varchar(100),
	PrimoTiempoD varchar(100),
	SobrinoTiempoD varchar(100),
	HijoEnfTiempoD varchar(100),
	TioEnfTiempoD varchar(100),
	MadreTrat bit,
	PadreTrat bit,
	HermanoTrat bit,
	ParejaTrat bit,
	AbueloTrat bit,
	PrimoTrat bit,
	SobrinoTrat bit,
	HijoTrat bit,
	TioEnfTrat bit,
	Alcohol varchar(50),
	Nicotina varchar(50),
	Cannabis varchar(50),
	Cocaina varchar(50),
	Sedantes varchar(50),
	Opiaceos varchar(50),
	Otros varchar(50),
	LoUsa varchar(50),
	SmarthPhone bit,
	Tablet bit,
	ComputadorFamiliar bit,
	ComputadorPropio bit,
	PortatilFamiliar bit,
	PortatilPropio bit,
	TV bit,
	Consola bit,
	SalaHogar bit,
	Habitacion bit,
	Universidad bit,
	TrabajoI bit,
	CasaAmigo bit,
	CasaFamiliar bit,
	OtrosPublicos bit,
	OtraVia bit,
	InternetCasa bit,
	InternetMobil bit,
	InternetTrabajo bit,
	InternetUniversidad bit,
	InternetPublico bit,
	fechaDiligen datetime);
go;