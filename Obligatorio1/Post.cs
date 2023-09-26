using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Post:Publicacion
    {

        public string Img { get; set; }

        public string Estado { get; set; }

        private List<Comentario> _listaComentarios = new List<Comentario>();

        public bool Censurado { get; set; }

        public Post(string contenido, DateTime fecha, Miembro miembro, string titulo,string img, string estado, bool censurado)
        :base(contenido,fecha,miembro,titulo)
        {
            Img = img;
            Estado = estado;
            Censurado = censurado;
        }

        public void ValidarPost()
        {
            ValidarImagen(Img);

        }

        //no vacío y debe terminar en “.jpg” o “.png”
        public static void ValidarImagen(string img)
        {
            if (string.IsNullOrEmpty(img))
            {
                throw new Exception("Imagen vacia");
            }

            string imgMin = img.ToLower();
            if (!imgMin.EndsWith(".jpg") && !imgMin.EndsWith(".png") )
            {
                throw new Exception("Formato de imagen no valido");
            }

        }

    
    }
}
