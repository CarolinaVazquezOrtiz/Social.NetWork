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
        }

        //Los comentarios a un post privado serán privados, y los correspondientes a un post público serán públicos.
        //Los posts privados solo podrán ser visualizados y comentados por los amigos de su autor.
        public void ValidarComentario()
        {
            base.Validar();
            //TERMINAR
        }


    }
}
