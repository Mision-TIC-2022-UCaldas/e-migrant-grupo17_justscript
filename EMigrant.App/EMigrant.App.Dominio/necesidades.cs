namespace EMigrant.App.Dominio{
    public class necesidades{

        public int id {get;set;}
        
        
        public string DescripcionSalud{get;set;}
         
        public PrioridadNecesidades PrioridadSalud{get;set;}

        public string DescripcionEmpleo {get;set;}
         
        public PrioridadNecesidades PrioridadEmpleo{get;set;}

        public string DescripcionEducacion {get;set;}
         
        public PrioridadNecesidades PrioridadEducacion{get;set;}


        public string DescripcionAyudaLegal {get;set;}
         
        public PrioridadNecesidades PrioridadAyudaLegal{get;set;}


        public string DescripcionAlojaTemporal {get;set;}
         
        public PrioridadNecesidades PrioridadTemporal{get;set;}

        public string DescripcionAlojaPermanente {get;set;}
         
        public PrioridadNecesidades PrioridadAlojaPermanente{get;set;}

        public string DescripcionAlimentacion {get;set;}
         
        public PrioridadNecesidades PrioridadAlimentacion{get;set;}


        public int UsuarioId {get;set;}
    }
}    