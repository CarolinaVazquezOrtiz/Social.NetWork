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

        public string FechaSolicitud { get; set; }

        public Invitacion(Miembro miembroSolicitado, Miembro miembroSolicitante, string estado, string fechaSolicitud)
        {

            Id = ++autID;
            MiembroSolicitado = miembroSolicitado;
            MiembroSolicitante = miembroSolicitante;
            Estado = estado;
            FechaSolicitud = fechaSolicitud;

            Console.WriteLine('mas cambios');
        }

        public void Validar()
        {
            ValidarMiembros();

        }

        public static void ValidarMiembros()
        {

        }

    }
}
