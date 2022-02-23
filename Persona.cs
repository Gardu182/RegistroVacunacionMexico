
namespace RegistroVacunacionMexico
{
    public class Persona
    {
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        private Int16 edad;
        private Byte sexo;
        private DateTime fechaNacimiento;
        private String estadoCivil;
        private String discapacidad;
        private Double ingresoMensual;
        private String correoElectronico;

        public Persona (String nombre, String apellidoPaterno, String apellidoMaterno, Int16 edad, 
                        Byte sexo, DateTime fechaNacimiento, String estadoCivil, 
                        String discapacidad, double ingresoMensual, String correoElectronico){

                            this.nombre = nombre;
                            this.apellidoPaterno = apellidoPaterno;
                            this.apellidoMaterno = apellidoMaterno;
                            this.edad = edad;
                            this.sexo = sexo;
                            this.fechaNacimiento = fechaNacimiento;
                            this.estadoCivil = estadoCivil;
                            this.discapacidad = discapacidad;
                            this.ingresoMensual = ingresoMensual;
                            this.correoElectronico = correoElectronico;

        }

        public String Nombre {get; set;}
        public String ApellidoPaterno {get; set;}
        public String ApellidoMaterno {get; set;}
        public Int16 Edad {get; set;}
        public Byte Sexo {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public String EstadoCivil {get; set;}
        public String Discapacidad {get; set;}
        public Double IngresoMensual {get; set;}
        public String CorreoElectronico {get; set;}


    }


}