using System;

namespace EMigrant.App.Dominio{
    public class RegistrarServicios{

        
        public int Id{get;set;}
        public string NombreServicio{get;set;}
        public int NumeroMaxMigrantes{get;set;}
        public DateTime FechaInicio{get;set;}
        public DateTime FechaFin{get;set;}
        public string EstadoServicio{get;set;} // Activo, Cerrado, Con cupo, Sin cupo
    }
}