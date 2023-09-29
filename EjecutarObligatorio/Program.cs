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
            Precargar();
            do
            {
                Console.Clear();      
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ingrese opcion: \n\n" +
                    "1-Registrar miembro\n" +
                    "2-Listar publicaciones de un miembro\n" +
                    "3-Listar posts de un miembro en los que haya realizado comentarios\n" +
                    "4-Listar posts entre 2 fechas\n" +
                    "5-Ver miembros con más publicaciones \n\n" +
                    "0-salir \n");
                Console.ResetColor();
                opcion = PedirNumero();

                if (opcion != 0)        //evita mostrar el mensaje por defecto si se ingresa 0 al iniciar
                {
                    switch (opcion)
                    {
                    case 1:
                        RegistrarMiembro();
                        break;
                    case 2:
                        ListarPubicacionesProgram();
                        break;
                    case 3:
                        ListarPostProgram();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Ingrese un número del 1 al 5, o pulse 0 para salir");
                        Console.ReadLine(); // Pausa para que el usuario pueda ver el mensaje de error
                        break;
                    }
                }

            } while (opcion != 0);
        }

        private static void Precargar()
        {
            try
            {
                unSistema.Precargas();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
                    numero = int.Parse(LeerCampoNoVacio());
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
                string nombre = LeerCampoNoVacio();

                Console.WriteLine("Ingrese el Apellido del Miembro:");
                string apellido = LeerCampoNoVacio();

                Console.WriteLine("Por favor, ingresa tu fecha de nacimiento (yyyy-MM-dd):");
                DateTime.TryParse(LeerCampoNoVacio(), out DateTime fechaNacimiento);

                Console.WriteLine("Ingrese el email del Miembro:");
                string email = LeerCampoNoVacio();

                Console.WriteLine("Ingrese la password del Miembro:");
                string password = LeerCampoNoVacio();

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

        // Metodo para asegurarme que no dejen campos vacios 
        public static string LeerCampoNoVacio()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Este campo no puede quedar vacío. Ingrésalo nuevamente: ");
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        /*Opc 2 - Dado un email de miembro listar todas las publicaciones que ha realizado, diferenciando en
        la lista su tipo(si es post o comentario)   */
        public static void ListarPubicacionesProgram()
        {
            try
            {
                Console.WriteLine("Ingrese el Mail del Miembro:");
                string email = LeerCampoNoVacio();

                if (unSistema.ExisteEmail(email))
                { 
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
                }else
                {
                    Console.WriteLine("No existe email");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        /*Opc 3 - Dado un email de miembro, listar los posts en los que haya realizado comentarios. 
        Se listarán solamente los posts, no los comentarios.  */
        public static void ListarPostProgram()
        {
            try
            {
                Console.WriteLine("Ingrese el Mail del Miembro:");
                string email = LeerCampoNoVacio();

                if (unSistema.ExisteEmail(email))
                {
                    List<Post> listaPostMiembro = unSistema.ListarPost(email);

                    if (listaPostMiembro.Count == 0)
                    {
                        Console.WriteLine("No existen Post");
                    }
                    else
                    {
                        foreach (Post post in listaPostMiembro)
                        {
                            Console.WriteLine($"Post de fecha {post.Fecha}; Título {post.Titulo}; texto: {post.Contenido}");
                        }
                    }
                }else
                {
                    Console.WriteLine("No existe email");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }


        /*Opc 4 - Dadas dos fechas listar los posts realizados entre esas fechas inclusive. Se deberá mostrar id,
        fecha, título y el texto del post. Si el texto del post supera los 50 caracteres, solo se
        mostrarán los primeros 50. No se mostrarán los comentarios de dichos posts. El listado
        estará ordenado por título en forma descendente.  */


        /*Opc 5 - Obtener los miembros que hayan realizado más publicaciones de cualquier tipo. Si hay más
        de un miembro con la misma cantidad de publicaciones mostrarlos todos. Se mostrarán
        todos los datos de los miembros.  */





    }
}