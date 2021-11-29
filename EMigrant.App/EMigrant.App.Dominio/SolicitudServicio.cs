using System;

namespace EMigrant.App.Dominio{
    public class SolicitudServicio{

        public int id{get;set;}
        
        public int emigranteId {get;set;}

        public int InstitucionId {get;set;}

        public string Usuario {get;set;}

        public string Institucion {get;set;}

        public string NombreServicio {get;set;}

        public DateTime FechaInicio {get;set;}

        public DateTime FechaFinalizacion {get;set;}  
        
         public string EstadoServicio {get;set;}   
    }
}