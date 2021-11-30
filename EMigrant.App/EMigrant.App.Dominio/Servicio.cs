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

        public bool ServicioSolicitado{get;set;} // verdadero: lo pide la persona, falso: lo asigna la institucion
        
        public bool ServicioCancelado{get;set;}

        public string EvaluarServicio{get;set;} // (Malo, Regular, Bueno, Muy Bueno, Excelente)
        
    
    }
}