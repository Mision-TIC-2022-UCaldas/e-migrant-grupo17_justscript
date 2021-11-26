namespace EMigrant.App.Dominio{
    public class Persona{

        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public TipoDoc TipoDocumento{get;set;}
        public string NumeroDocumento{get;set;}
        public Date FNacimiento{get;set;}
        public string Correo{get;set;}
        public string Telefono{get;set;}
        public string Direccion{get;set;}
        public string Ciudad{get;set;}
        
        
    }
}