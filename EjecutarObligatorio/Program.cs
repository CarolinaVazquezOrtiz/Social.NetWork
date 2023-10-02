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
                        ListarPostsComentados();
                        break;
                    case 4:
                        ListarPostsEntreFechas();
                        break;
                    case 5:
                        MiembrosConMasPublicaciones();
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

                Console.WriteLine("Ingrese el email del Miembro:");
                string email = Console.ReadLine();
                if (string.IsNullOrEmpty(email))
                {
                    throw new Exception("El campo esta vacio, ingrese un email");
                }
                if (unSistema.ExisteEmail(email))
                {
                    throw new Exception("El email que ingreso ya existe");
                }

                Console.WriteLine("Ingrese el Nombre del Miembro:");
                string nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("El campo esta vacio, ingrese un nombre");
                }

                Console.WriteLine("Ingrese el Apellido del Miembro:");
                string apellido = Console.ReadLine();
                if (string.IsNullOrEmpty(apellido))
                {
                    throw new Exception("El campo esta vacio, ingrese un apellido");
                }

                Console.Write("Ingrese su fecha de nacimiento (yyyy-MM-dd): ");
                string input = Console.ReadLine();
                DateTime fechaNacimiento;
                if (DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                {
                    // Verificar que la fecha de nacimiento no sea mayor que la fecha actual
                    if (fechaNacimiento >= DateTime.Now)
                    {
                        throw new Exception("La fecha de nacimiento no puede ser mayor que la fecha actual.");
                    }
                }
                else
                {
                    throw new Exception("Formato de fecha no válido. Debe ser yyyy-MM-dd.");
                }

                Console.WriteLine("Ingrese la password del Miembro:");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("El campo esta vacio, ingrese una password");
                }

                Miembro nuevoMiembro = new Miembro(email, password, false, nombre, apellido, fechaNacimiento);
                string mensaje = unSistema.CrearNuevoMiembro(nuevoMiembro);
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

                if (!string.IsNullOrEmpty(email))
                {

                    List<Publicacion> listaPubMiembro = unSistema.ListarPublicaciones(email);

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
                                Post post = (Post)pub;
                                Console.WriteLine($"Post de fecha {post.Fecha}; Título {post.Titulo}; texto: {post.Contenido}; Imagen: {post.Img}");
                            }
                            if (pub is Comentario)
                            {
                                Comentario comentario = (Comentario)pub;
                                Console.WriteLine($"Comentario de fecha {comentario.Fecha}; Título {comentario.Titulo}; texto: {comentario.Contenido}");
                            }
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("El campo esta vacio, ingrese un mail");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        //Opc 3 - Dado un email de mimebro, listar los posts en loq eu haya realizado comentarios.
        public static void ListarPostsComentados()
        {
            try
            {
                Console.WriteLine("Ingrese el Mail del Miembro:");
                string email = Console.ReadLine();

                if (!string.IsNullOrEmpty(email))
                {
                    List<Post> listaPostsComentados = unSistema.ListarPost(email);

                    if (listaPostsComentados.Count == 0)
                    {
                        throw new Exception("No existen comentarios relacionados a post");
                    }
                    else
                    {
                        foreach (Post post in listaPostsComentados)
                        {

                            Console.WriteLine($"Post de fecha {post.Fecha}; Título {post.Titulo}; texto: {post.Contenido}; Imagen: {post.Img}");
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("El campo esta vacio, ingrese un mail");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        //Opc 4 - Listar entre dos fechas incluidas todos los Posts.
        public static void ListarPostsEntreFechas()
        {
            try
            {
                Console.WriteLine("Por favor, ingresa la primer fecha (yyyy-MM-dd):");
                DateTime.TryParse(Console.ReadLine(), out DateTime primerFecha);

                Console.WriteLine("Por favor, ingresa la segunda fecha (yyyy-MM-dd):");
                DateTime.TryParse(Console.ReadLine(), out DateTime segundaFecha);
                Console.WriteLine();

                if (primerFecha != DateTime.MinValue && segundaFecha != DateTime.MinValue)
                {
                    List<Post> listaPostsComentados = unSistema.ListarPostFecha(primerFecha, segundaFecha);

                    if (listaPostsComentados.Count == 0)
                    {
                        throw new Exception("No existen comentarios relacionados a post");
                    }
                    else
                    {
                        foreach (Post post in listaPostsComentados)
                        {
                            string textoPost = (post.Contenido.Length > 50) ? post.Contenido.Substring(0, 50) : post.Contenido;
                            Console.WriteLine($"Id: {post.Id}; Fecha: {post.Fecha}; Título: {post.Titulo}; texto: {textoPost};");
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Uno de los campos fecha esta vacio");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        //Opc 5 - Desplegar los mimebros con mas publicaciones
        public static void MiembrosConMasPublicaciones()
        {
            try
            {
                List<Miembro> listaMimebroFiltrada = unSistema.MiembrosMasPublicaciones();

                if (listaMimebroFiltrada.Count == 0)
                {
                    throw new Exception("No existen mimebros con publicaciones");
                }
                else
                {
                    foreach (Miembro miem in listaMimebroFiltrada)
                    {
                        Console.WriteLine($"Nombre: {miem.Nombre}; Apellido: {miem.Apellido}; Fecha de Nacimiento: {miem.FechaNac}; Email: {miem.Email}; Password: {miem.Password};");
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