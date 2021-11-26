using System;

namespace EMigrant.App.Dominio{
    public class Institucion{

        
        public int Id{get;set;}
        public string RazonSocial{get;set;}
        public string Nit{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Email{get;set;}
        public string PagWeb{get;set;}

        public string SectorInstitucion{get;set;} // verdadero: lo pide la persona, falso: lo asigna la institucion
        
        public TipoServicio TipoServicio{get;set;}
    
    }
}