

namespace RegistroVacunacionMexico
{
    public class Vacuna
    {

        //Propiedades
        public DateTime FechaAplicacion {get; set;}
        public DateTime HoraAplicacion {get; set;}
        public double ImpuestoAplicacion {get; init;} = 0.015;



        //Metodos de la clase Vacuna
        public DateTime calcularTiempoEfectividad(){

           DateTime today = DateTime.Now;
           DateTime diasEfectividad = today.AddDays(180);
           return diasEfectividad;

        }

        public double calcularImpuestoAplicacion(Double IngresoMensual){

            double costoTotal;
            return costoTotal = IngresoMensual * ImpuestoAplicacion;

        }

        public DateTime mostrarIndicaciones(){

           DateTime today = DateTime.Now;
           DateTime hrsDescanso = today.AddHours(5);
           return hrsDescanso;

        }

        public string generarFolioVacunacion(String nombre, String apellidoP, String apellidoM){
            
            string folioVacunacion = " ";
            int startIndex = 0;
            int length = 1;
            Random rmd = new Random();
            int numero = rmd.Next(0,1000);
            String substringNom = nombre.Substring(startIndex, length);
            String substringApeP = apellidoP.Substring(startIndex, length);
            String substringApeM = apellidoM.Substring(startIndex, length);
            folioVacunacion = substringNom + substringApeP + substringApeM + numero; 
            return folioVacunacion;

        }


    }

}