using System;

namespace EMigrant.App.Dominio{
    public class Servicio{

        public int Id{get;set;}
        public string Descripcion{get;set;}
        public Institucion Institucion{get;set;}
        public TipoServicio TipoServicio{get;set;}
        public DateTime FSolicitud{get;set;}
        public DateTime FechaRespuesta{get;set;}
        public string EstadoSolicitud{get;set;}
        
    
    }
}