
namespace RegistroVacunacionMexico
{
    public class Persona
    { 

        //Propiedades
        public string Nombre {get; set;}
        public string ApellidoPaterno {get; set;}
        public string ApellidoMaterno {get; set;}
        public bool Sexo {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string EstadoCivil {get; set;}
        public string Discapacidad {get; set;}
        public Double IngresoMensual {get; set;}
        public String CorreoElectronico {get; set;}        
        

        //Metodos de la clase Persona
        public double calcularEdad(DateTime fechaNacString){

            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacString;
            double dias = diferencia.TotalDays;
            double anos = Math.Floor(dias/365);
            return anos;

        }


    }


}