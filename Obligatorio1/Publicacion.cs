using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{

    public class Publicacion
    {
        //Static
        private static int autID;

        //Datos
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public Miembro Miembro { get; set; }
        public string Titulo { get; set; }

        //Constructor
        public Publicacion(string contenido, DateTime fecha, Miembro miembro, string titulo)
        {
            Id = ++autID;
            Contenido = contenido;
            Fecha = fecha;
            Miembro = miembro;
            Titulo = titulo;
        }

        public void Validar()
        {
            ValidarContendio();
            ValidarTitulo();
            ValidarMiembro();
        }

        public static void ValidarContendio()
        {

        }

        public static void ValidarTitulo()
        {
            
        }

        public static void ValidarMiembro()
        {

        }

    }
}
