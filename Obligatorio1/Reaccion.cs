using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Reaccion
    {

        public string TipoReaccion { get; set; }

        public Miembro Miembro { get; set; }

        public Publicacion PublicacionReaccionada { get; set; }

        public Reaccion(string tipoReaccion, Miembro miembro, Publicacion publicacionReaccionada)
        {
            TipoReaccion = tipoReaccion;
            Miembro = miembro;
            PublicacionReaccionada = publicacionReaccionada;
            ValidarReaccion();
        }
        
        /// <summary>
        ///     Esta funcion llama al validar Tipo Reaccion
        /// </summary>
        public void ValidarReaccion()
        {
            ValidarTipoReaccion(TipoReaccion);
        }

        /// <summary>
        ///     Esta funcion verifica que el tipo de reaccion se dislike o like en caso contrario
        ///     larga una excepcion
        /// </summary>
        public static void ValidarTipoReaccion(string tipoReaccion)
        {
            if (tipoReaccion.ToLower() != "like" && tipoReaccion.ToLower() != "dislike")
            {
                throw new Exception($"Tipo de reaccion: {tipoReaccion} no es valido");
            }
        }


    }
}
