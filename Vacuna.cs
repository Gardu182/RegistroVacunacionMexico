
namespace RegistroVacunacionMexico
{
    public class Vacuna
    {
        private DateTime fechaAplicacion;
        private DateTime horaAplicacion;
        private DateTime impuestoAplicacion;

        public Vacuna (DateTime fechaAplicacion, DateTime horaAplicacion, DateTime impuestoAplicacion){

            this.fechaAplicacion = fechaAplicacion;
            this.horaAplicacion = horaAplicacion;
            this.impuestoAplicacion = impuestoAplicacion;

        }

        public DateTime FechaAplicacion {get; set;}
        public DateTime HoraAplicacion {get; set;}
        public DateTime ImpuestoAplicacion {get; set;}


    }

}