using Obligatorio1;

namespace EjecutarObligatorio
{
    public class Program
    {
        private static Sistema unSistema = new Sistema();
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
                        //RegistrarMiembro();
                        break;
                    case 2:
                        break;
                }

            } while (opcion != 0);
        }

        static private int PedirNumero()
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



    }
}