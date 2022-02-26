
namespace RegistroVacunacionMexico
{
    public class Persona
    { 

        //Propiedades
        public string Nombre {get; set;}
        public string ApellidoPaterno {get; set;}
        public string ApellidoMaterno {get; set;}
        public int Edad {get; set;}
        public bool Sexo {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string EstadoCivil {get; set;}
        public string Discapacidad {get; set;}
        public double IngresoMensual {get; set;}
        public string CorreoElectronico {get; set;}        
        

        //Metodos de la clase Persona
        public void calcularEdad(DateTime fechaNacString){

            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacString;
            int dias = Convert.ToInt32(diferencia.TotalDays);
            int anos = Convert.ToInt32(dias/365);
            this.Edad = anos;

        }


    }


}