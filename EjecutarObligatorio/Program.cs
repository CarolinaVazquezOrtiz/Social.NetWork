using Obligatorio1;
using System.Security.Cryptography.X509Certificates;

namespace EjecutarObligatorio
{
    public class Program
    {
        private static Sistema unSistema = new Sistema();
        //Precarga de datos
        //Precargar();

        static void Main(string[] args)
        {
            //---menú en consola---
            int opcion;
            do
            {
                //Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ingrese opcion: \n\n" +
                    "1-Registrar miembro\n" +
                    "2-Listar publicaciones de un miembro\n" +
                    "3-Listar posts de un miembro\n" +
                    "4-Listar posts entre 2 fechas\n" +
                    "5-Ver miembros con más publicaciones \n\n" +
                    "0-salir \n");
                Console.ResetColor();
                opcion = PedirNumero();
                switch (opcion)
                {
                    case 1:
                        RegistrarMiembro();
                        break;
                    case 2:
                        ListarPubicacionesProgram();
                        break;
                }

            } while (opcion != 0);
        }

        private static void Precargar()
        {
            try
            {
                unSistema.Precargas();
                Console.WriteLine("Precarga de datos correcta");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        private static int PedirNumero()
        {
            int numero = 0;
            bool salir = false;
            do
            {
                try
                {
                    salir = true;
                    numero = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    salir = false;
                    Console.WriteLine("Solo debe ingresar numeros");
                }
            } while (!salir);

            return numero;
        }

        //Opc 1 - Registrar miembro
        public static void RegistrarMiembro()
        {
            try
            {
                Console.WriteLine("Ingrese el Nombre del Miembro:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el Apellido del Miembro:");
                string apellido = Console.ReadLine();

                Console.WriteLine("Por favor, ingresa tu fecha de nacimiento (yyyy-MM-dd):");
                DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento);

                Console.WriteLine("Ingrese el email del Miembro:");
                string email = Console.ReadLine();

                Console.WriteLine("Ingrese la password del Miembro:");
                string password = Console.ReadLine();

                Miembro nuevoMiembro = new Miembro(email, password, false, nombre, apellido, fechaNacimiento);
                string mensaje=unSistema.CrearNuevoMiembro(nuevoMiembro);
                Console.WriteLine(mensaje);
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        /*Opc 2 - Dado un email de miembro listar todas las publicaciones que ha realizado, diferenciando en
        la lista su tipo(si es post o comentario)   */
        public static void ListarPubicacionesProgram()
        {
            try
            {
                Console.WriteLine("Ingrese el Mail del Miembro:");
                string email = Console.ReadLine();

                List<Publicacion> listaPubMiembro = unSistema.ListarPubicaciones(email);

                if (listaPubMiembro.Count == 0)
                {
                    Console.WriteLine("No existen Publicaciones");
                }
                else
                {
                    foreach (Publicacion pub in listaPubMiembro)
                    {
                        if (pub is Post)
                        {
                            Console.WriteLine($"Post de fecha {pub.Fecha}; Título {pub.Titulo}; texto: {pub.Contenido}");
                        }
                        if (pub is Comentario)
                        {
                            Console.WriteLine($"Comentario de fecha {pub.Fecha}; Título {pub.Titulo}; texto: {pub.Contenido}");
                        }
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

    }
}