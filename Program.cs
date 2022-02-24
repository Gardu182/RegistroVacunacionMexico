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
                            String name = Console.ReadLine();
                            Console.WriteLine("Apellido Paterno:");
                            String apelidoPaterno = Console.ReadLine();
                            Console.WriteLine("Apellido Materno:");
                            String apellidoMaterno = Console.ReadLine();
                            Console.WriteLine("Sexo:");
                            byte sexo = Console.ReadLine();
                            Console.WriteLine("Fecha de Nacimiento en Formato dd//MM/yyyy");
                            DateTime fechaNacimiento = Console.ReadLine();
                            Console.WriteLine("Estado Civil:");
                            String estadoCivil = Console.ReadLine();
                            Console.WriteLine("Discapacidad:");
                            String discapacidad = Console.ReadLine();
                            Console.WriteLine("Ingreso Mensual:");
                            Double ingresoMensual = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Correo Electronico:");
                            String correoElectronico = Console.ReadLine();
                            Persona persona = new Persona(name, apelidoPaterno, apellidoMaterno, sexo, fechaNacimiento, estadoCivil, discapacidad, ingresoMensual, correoElectronico);
                            break;//Salimos del bloque
 
                        case 2://Si coincide con 2
                            Console.WriteLine("Opción 2");
                            break;
 
                        case 3:
                            Console.WriteLine("Opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Opcion 4");
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



