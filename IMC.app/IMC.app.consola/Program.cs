using System;

namespace IMC.app.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            float  Peso     = 0;
		float  Estatura = 0;	
		float  IMC	    = 0;
		String Estado   = "";
		Char   Opcion   = ' ';
		
		do{
				
			//Titulo de la Ventana
			Console.Title = "Calculo de IMC";
		
			//Solicitar Datos
			try{
			Console.WriteLine("Ingrese Peso (kg)");
			Peso = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese Altura (m)(Ej. 1,6)");
			Estatura = float.Parse(Console.ReadLine());

            }
            catch(FormatException e){
                Console.Write("Debe ingresar obligatoriamente un números");
            }
			//Realizar Calculo
			
			IMC = (Peso/(Estatura * Estatura));
			
			//Determinar estado de la persona
			
			if (IMC <= 16){
				Estado = "Delgadez severa";
			}

            if ((IMC >= 16) && (IMC <= 16.99)){
				Estado = "Delgadez moderada";
			}

             if ((IMC <= 18.49) && (IMC >= 17)){
				Estado = "Delgadez aceptable";
			}

             if ((IMC <= 24.99) && (IMC >= 18.5)){
				Estado = "Peso normal";
			}

            if ( (IMC >= 25) && (IMC <= 29.99)){
				Estado = "Sobrepeso";
			}

             if ( (IMC >= 30) && (IMC <= 34.99)){
				Estado = "Obesidad tipo I";
			}

             if ( (IMC >= 35) && (IMC <= 39.99)){
				Estado = "Obesidad tipo II";
			}

             if ( (IMC >= 40) && (IMC <= 49.99)){
				Estado = "Obesidad tipo III o mórbida";
			}

             if (IMC >= 50) {
				Estado = "Obesidad tipo IV o extrema";
			}

            
			
			//Mostrar Resultado
			
			Console.WriteLine("Su IMC es de :" + IMC);
			Console.WriteLine("Su estado es :" + Estado);
			
			//Preguntar si repie calculo
			Console.WriteLine("Desea Continuar? (S = Si / N = No)");
			Opcion = Console.ReadKey(true).KeyChar;
			
		}while ((Opcion == 'S') || (Opcion == 's'));
        
        }
    }
}
