
namespace RegistroVacunacionMexico
{
    public class Persona
    { 
        //Atributos de la clase Persona
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        private Byte sexo;
        private DateTime fechaNacimiento;
        private String estadoCivil;
        private String discapacidad;
        private Double ingresoMensual;
        private String correoElectronico;

        //Constructor de la clase persona
        public Persona (String nombre, String apellidoPaterno, String apellidoMaterno, 
                        Byte sexo, DateTime fechaNacimiento, String estadoCivil, 
                        String discapacidad, double ingresoMensual, String correoElectronico){

                            this.nombre = nombre;
                            this.apellidoPaterno = apellidoPaterno;
                            this.apellidoMaterno = apellidoMaterno;
                            this.sexo = sexo;
                            this.fechaNacimiento = fechaNacimiento;
                            this.estadoCivil = estadoCivil;
                            this.discapacidad = discapacidad;
                            this.ingresoMensual = ingresoMensual;
                            this.correoElectronico = correoElectronico;

        }
        
        //Getters y Setters de la calse Persona
        public String Nombre {get; set;}
        public String ApellidoPaterno {get; set;}
        public String ApellidoMaterno {get; set;}
        public Byte Sexo {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public String EstadoCivil {get; set;}
        public String Discapacidad {get; set;}
        public Double IngresoMensual {get; set;}
        public String CorreoElectronico {get; set;}

        //Metodos de la clase Persona
        public void calcularEdad(String fechaNacString){

            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);
            DateTime fechaActual = DateTime.Now;
            int anos = fechaActual.Year-fechaNacimiento.Year;
 
        }


    }


}