using System;

namespace EMigrant.App.Dominio{
    public class OfertaServicio{

        public int id{get;set;}
        
        public int InstitucionId {get;set;}

        public string Institucion {get;set;}

        public string TipoServicio {get;set;}
        public string NombreServicio {get;set;}

        public string MaxMigrantes {get;set;}

        public DateTime FechaInicio {get;set;}

        public DateTime FechaFinalizacion {get;set;}  


        
         public string EstadoServicio {get;set;}   
    }
}