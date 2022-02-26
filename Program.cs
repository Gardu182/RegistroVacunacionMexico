// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistroVacunacionMexico
{
    class Program
    {
        //Método main
        static void Main(string[] args)
        {
            Persona person = new Persona();
            Vacuna vacuna = new Vacuna();
            bool salir = false; //Variable que nos permite saber si el usuario quiere salir o no
            while (!salir) { //Mientras el usuario no quiera salir se repite:
                try //Envolvemos el código que puede generar error en un bloque try-catch, el error puede ser que no nos de un número como opción
                {                     
                    //Opciones del menú
                    Console.WriteLine("1. Registro");
                    Console.WriteLine("2. Consultar Datos");
                    Console.WriteLine("3. Consultar Efectividad");
                    Console.WriteLine("4. Mostrar Indicaciones");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    //Convertimos a entero la opción introducida por el usuario, si ocurre un error al convertir se va a l bloque catch
                    int opcion = Convert.ToInt32(Console.ReadLine());
    
                    //Estructura de control que nos permite ir a una porción u otra de código
                    //Opcion es la variable de control si coincide con una opcion entra a ese bloque de código
                    switch (opcion)
                    {
                        case 1://Si coincide con 1
                            Console.WriteLine("-----Confirmacion de Datos Personales-----");
                            Console.WriteLine("Nombre:");
                            person.Nombre = Console.ReadLine();
                            Console.WriteLine("Apellido Paterno:");
                            person.ApellidoPaterno = Console.ReadLine();
                            Console.WriteLine("Apellido Materno:");
                            person.ApellidoMaterno = Console.ReadLine();
                            Console.WriteLine("Sexo: 1 masculino, 0 femenino");
                            int result = Convert.ToInt16(Console.ReadLine());
                            person.Sexo = result == 1 ? true : false;
                            Console.WriteLine("Fecha de Nacimiento en Formato dd/MM/yyyy");
                            string fechaNacString = Console.ReadLine();
                            try{

                                DateTime fechaNacimiento = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);
                                person.FechaNacimiento = fechaNacimiento;
                                person.calcularEdad(fechaNacimiento);


                            }catch(Exception e){

                                Console.WriteLine("Favor de escribir la fecha de nacimiento en el formato correcto dd/MM/yyy");
                                person.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

                            }
                            Console.WriteLine("Estado Civil:");
                            person.EstadoCivil = Console.ReadLine();
                            Console.WriteLine("Discapacidad:");
                            person.Discapacidad = Console.ReadLine();
                            Console.WriteLine("Ingreso Mensual:");
                            person.IngresoMensual = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Correo Electronico:");
                            person.CorreoElectronico = Console.ReadLine();
                            break;//Salimos del bloque
 
                        case 2://Si coincide con la opcion 2
                            string genero = person.Sexo == true ? "Masculino" : "Femenino";
                            double ingresoPersona = person.IngresoMensual;
                            double costoAplicacion = vacuna.calcularImpuestoAplicacion(ingresoPersona);
                            Console.WriteLine("****Datos del Vacunado****");
                            Console.WriteLine("Paciente: " + person.Nombre + " " + person.ApellidoPaterno + " " + person.ApellidoMaterno);
                            Console.WriteLine("Fecha de Nacimiento: " + person.FechaNacimiento.ToShortDateString());
                            Console.WriteLine("Edad:" + person.Edad + " anos");
                            Console.WriteLine("Sexo: "+ genero);
                            Console.WriteLine("Estado civil: " + person.EstadoCivil);
                            Console.WriteLine("Correo electronico: " + person.CorreoElectronico);
                            Console.WriteLine("Discapacidad: " + person.Discapacidad);
                            Console.WriteLine("Ingreso: " + String.Format("{0:C}", person.IngresoMensual + " Pesos"));
                            Console.WriteLine("Folio de vacunacion: " + vacuna.generarFolioVacunacion(person.Nombre, person.ApellidoPaterno, person.ApellidoMaterno));
                            Console.WriteLine("La vacuna no sera efectiva despues de: " + vacuna.calcularTiempoEfectividad().ToShortDateString());
                            Console.WriteLine("Nota: la vacuna cuenta con un costo dependiendo del salario mensual");
                            Console.WriteLine("El impuesto por aplicacion es de: " + String.Format("{0:C}", costoAplicacion + " Pesos"));
                            break;
 
                        case 3://Si conincide con la opcion 3
                            Console.WriteLine("************Cuidado************");
                            Console.WriteLine("La vacuna no sera efectiva despues del: " + vacuna.calcularTiempoEfectividad().ToShortDateString());
                            Console.WriteLine("************Cuidado************");
                            break;

                        case 4://Si conincide con la opcion 4
                            Console.WriteLine("****Indicaciones de Vacunacion contra COVID-19****");
                            Console.WriteLine("Favor de no hacer ningun tipo de ejercicio despues de las " + vacuna.mostrarIndicaciones().ToString("h:mm tt"));
                            Console.WriteLine("es necesario guardar reposo y observar cualquier efecto secundario como:");
                            Console.WriteLine("dolor de cabeza, huesos, mareos o algun otro, de ser asi reportarse con su medico de cabecera.");

                            break;

                        case 5:
                            Console.WriteLine("Hasta luego");
                            salir = true;
                            break;

                        default://Si no coincide con las opciones de 1 a 4 se ejecuta esto siempre que sea un número
                            Console.WriteLine("Opción no válida, elige una opcion entre 1 y 5");
                            break;
                    } 
                }
                catch (FormatException e)//Capturamos la excepción que pueda ocurrir
                {
                    Console.WriteLine("Formato incorrecto " + e.Message);//Mostramos el mensaje de la excepcioón
                }
            }
 
            Console.ReadLine();//Leemos un caracter para que haga una pausa antes de salir
 
        }
        
    }


}



