namespace EMigrant.App.Dominio{
    public class migrante : Persona{

        public string PaisOrigen{get;set;}
        public SituacionLaboral SituacionLaboral{get;set;}
        public Salud Salud{get;set;}
        public Alimentacion Alimentacion{get;set;}
        public Empleo Empleo{get;set;}
        public AlojoTemporal AlojoTemporal{get;set;}
        public AlojoPermanente AlojoPermanente{get;set;}
        public Educacion Educacion{get;set;}
        public AyudaLegal AyudaLegal{get;set;}
        public string Usuario {get;set;}

        public string Clave {get;set;}
            
        public string cat {get;set;}
    }
}    