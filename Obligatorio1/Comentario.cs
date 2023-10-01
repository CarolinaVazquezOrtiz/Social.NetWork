using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Comentario:Publicacion
    {
        public bool EsPrivado { get; set; }

        public Post Post { get; set; }

        public Comentario(Post post, string contenido, DateTime fecha, Miembro miembro, string titulo,bool esPrivado)
        :base(contenido,fecha,miembro,titulo)
        {
            Post = post;
            EsPrivado = esPrivado;
            ValidarComentario();
        }

        public void ValidarComentario()
        {
            base.Validar();
        }


    }
}
