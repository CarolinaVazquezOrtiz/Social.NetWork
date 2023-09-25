using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Comentario:Publicacion
    {
        public bool EsPrivado;

        public Comentario(string contenido, DateTime fecha, Miembro miembro, string titulo,bool esPrivado)
        :base(contenido,fecha,miembro,titulo)
        {
            EsPrivado = esPrivado;
        }



    }
}
