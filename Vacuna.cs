
namespace RegistroVacunacionMexico
{
    public class Vacuna
    {
        //Atributos de la clase Vacuna
        private DateTime fechaAplicacion;
        private DateTime horaAplicacion;
        private DateTime impuestoAplicacion;
        
        //Constructor de la clase Vacuna
        public Vacuna (DateTime fechaAplicacion, DateTime horaAplicacion, DateTime impuestoAplicacion){

            this.fechaAplicacion = fechaAplicacion;
            this.horaAplicacion = horaAplicacion;
            this.impuestoAplicacion = impuestoAplicacion;

        }
        //Getters y Setters de la clase Vacuna
        public DateTime FechaAplicacion {get; set;}
        public DateTime HoraAplicacion {get; set;}
        public DateTime ImpuestoAplicacion {get; set;}

        //Metodos de la clase Vacuna
        public void calcularTiempoEfectividad(){

            //fechaAplicacion = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);

        }

        public void calcularImpuestoAplicacion(){

        }

        public void mostrarIndicaciones(){

        }

        public void generarFolioVacunacion(){

        }


    }

}