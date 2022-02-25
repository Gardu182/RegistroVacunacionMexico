

namespace RegistroVacunacionMexico
{
    public class Vacuna
    {

        //Propiedades
        public DateTime FechaAplicacion {get; set;}
        public DateTime HoraAplicacion {get; set;}
        public double ImpuestoAplicacion {get; init;} = 0.015;



        //Metodos de la clase Vacuna
        public void calcularTiempoEfectividad(){


        }

        public double calcularImpuestoAplicacion(Double IngresoMensual){

            double costoTotal;
            return costoTotal = IngresoMensual * ImpuestoAplicacion;

        }

        public void mostrarIndicaciones(){

        }

        public void generarFolioVacunacion(){

        }


    }

}