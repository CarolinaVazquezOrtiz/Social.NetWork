using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Invitacion
    {
        private static int autID;

        public int Id { get; set; }

        public Miembro MiembroSolicitado { get; set; }

        public Miembro MiembroSolicitante { get; set; }

        public string Estado { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public Invitacion(Miembro miembroSolicitado, Miembro miembroSolicitante, string estado, DateTime fechaSolicitud)
        {

            Id = ++autID;
            MiembroSolicitado = miembroSolicitado;
            MiembroSolicitante = miembroSolicitante;
            Estado = estado;
            FechaSolicitud = fechaSolicitud;
            ValidarInvitacion();
        }

        /// <summary>
        ///     Esta funcion llama a una funcion secundaria statica
        /// </summary>
        public void ValidarInvitacion()
        {
            ValidarEstado(Estado);
        }

        /// <summary>
        ///     Esta funcion se le pasa un estado el cual es string y se verifica que no sea disitino a ninguno de los estados
        ///     que se piden en la letra del Obligatorio , en el caso contrario se larga una excepcion
        /// </summary>
        public static void ValidarEstado(string estado)
        {
            if (estado != "aprobada" && estado != "proceso" && estado != "rechazada")
            {
                throw new Exception("El estado en Invitacion no es valido.");
            }
        }

    }
}
