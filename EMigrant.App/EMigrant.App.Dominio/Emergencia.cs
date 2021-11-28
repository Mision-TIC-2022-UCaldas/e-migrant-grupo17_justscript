namespace EMigrant.App.Dominio
{
    public class Emergencia
    {
        public int id{get;set;}
        public string DescripcionEmergencia {get;set;}
        public string reportadaPor{get;set;}
        public string ciudad{get;set;}
        public string estadoEmergencia{get;set;}
        public OrganismoEmergencia atendidoPor{get;set;}

    }
}