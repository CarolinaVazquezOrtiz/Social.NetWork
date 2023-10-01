
﻿using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Obligatorio1
{
    public class Sistema
    {

        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private List<Invitacion> _listaInvitaciones = new List<Invitacion>();
        private List<Publicacion> _listaPubicaciones = new List<Publicacion>();
        private List<Reaccion> _listaReacciones = new List<Reaccion>();

        public List<Usuario> ListaUsuarios { get { return _listaUsuarios; } }
        public List<Invitacion> ListaInvitaciones { get { return _listaInvitaciones; } }
        public List<Publicacion> ListaPublicaciones { get { return _listaPubicaciones; } }
        public List<Reaccion> ListaReacciones { get { return _listaReacciones; } }


        //-------------PRECARGA DE DATOS------------

        
        
        public void Precargas()
        {
            PrecargarMiembros();
            PrecargarAdministradores();
            PrecargarInvitaciones();
            PrecargarPosts();
            PrecargarComentarios();
            PrecargarReacciones();
        }

        private void PrecargarMiembros()
        {
            Miembro miembro1 = new Miembro("caro19@gmail.com", "Estrella-1", false, "Carolina", "Vazquez", new DateTime(1991, 10, 10));
            CrearNuevoMiembro(miembro1);
            Miembro miembro2 = new Miembro("sofia88@gmail.com", "Lunas-88", false, "Sofia", "Ortiz", new DateTime(1988, 10, 03));
            CrearNuevoMiembro(miembro2);
            Miembro miembro3 = new Miembro("carlos90@gmail.com", "Neptuno-90", false, "Carlos", "Lopez", new DateTime(1995, 10, 03));
            CrearNuevoMiembro(miembro3);
            Miembro miembro4 = new Miembro("juan19@gmail.com", "Jupiter-19", false, "Carlos", "Lopez", new DateTime(1960, 08, 08));
            CrearNuevoMiembro(miembro4);
            Miembro miembro5 = new Miembro("facundo44@gmail.com", "Urano-44", false, "Facundo", "Gomez", new DateTime(1999, 04, 04));
            CrearNuevoMiembro(miembro5);
            Miembro miembro6 = new Miembro("bruno21@gmail.com", "Saturno-21", false, "Bruno", "Gonzalez", new DateTime(2020, 01, 01));
            CrearNuevoMiembro(miembro6);
            Miembro miembro7 = new Miembro("Monica99@gmail.com", "Mercurio*99", false, "Moria", "Casanova", new DateTime(1960, 08, 08));
            CrearNuevoMiembro(miembro7);
            Miembro miembro8 = new Miembro("anita@gmail.com", "Venus.19", false, "Ana", "Moreira", new DateTime(1960, 08, 08));
            CrearNuevoMiembro(miembro8);
            Miembro miembro9 = new Miembro("tony1990@gmail.com", "Tierra_19", false, "Antonio", "Salvat", new DateTime(2021, 06, 06));
            CrearNuevoMiembro(miembro9);
            Miembro miembro10 = new Miembro("second2@gmail.com", "Marte$19", false, "Segundo", "Machado", new DateTime(1988, 08, 08));
            CrearNuevoMiembro(miembro10);
            Miembro miembro11 = new Miembro("zara@gmail.com", "Nept-1771", false, "Zara", "Machado", new DateTime(1990, 08, 08));
            CrearNuevoMiembro(miembro11);       //posicion 10 de la lista
        }

        private void PrecargarAdministradores()
        {
            Administrador admin1 = new Administrador("guille77@gmail.com", "Pluton-77", true);
            CrearNuevoAdministrador(admin1);
        }

        private void PrecargarInvitaciones()
        {
            //Invitaciones del miembro en posicion 0 en estado APROBADO
            Invitacion invita1 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[1] as Miembro, "aprobada", new DateTime(1988, 08, 08));
            CrearNuevaInvitacion(invita1);
            Invitacion invita2 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[2] as Miembro, "aprobada", new DateTime(1990, 09, 15));
            CrearNuevaInvitacion(invita2);
            Invitacion invita3 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[3] as Miembro, "aprobada", new DateTime(1992, 11, 20));
            CrearNuevaInvitacion(invita3);
            Invitacion invita4 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[4] as Miembro, "aprobada", new DateTime(1989, 07, 05));
            CrearNuevaInvitacion(invita4);
            Invitacion invita5 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[5] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita5);
            Invitacion invita6 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[6] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita6);
            Invitacion invita7 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[7] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita7);
            Invitacion invita8 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[8] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita8);
            Invitacion invita9 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[9] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita9);
            Invitacion invita10 = new Invitacion(_listaUsuarios[0] as Miembro, _listaUsuarios[10] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita10);

            //Invitaciones del miembro en posicion 1 en estado APROBADO
            Invitacion invita11 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[2] as Miembro, "aprobada", new DateTime(1988, 08, 08));
            CrearNuevaInvitacion(invita11);
            Invitacion invita12 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[3] as Miembro, "aprobada", new DateTime(1990, 09, 15));
            CrearNuevaInvitacion(invita12);
            Invitacion invita13 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[4] as Miembro, "aprobada", new DateTime(1992, 11, 20));
            CrearNuevaInvitacion(invita13);
            Invitacion invita14 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[5] as Miembro, "aprobada", new DateTime(1989, 07, 05));
            CrearNuevaInvitacion(invita14);
            Invitacion invita15 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[6] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita15);
            Invitacion invita16 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[7] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita16);
            Invitacion invita17 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[8] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita17);
            Invitacion invita18 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[9] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita18);
            Invitacion invita19 = new Invitacion(_listaUsuarios[1] as Miembro, _listaUsuarios[10] as Miembro, "aprobada", new DateTime(2023, 09, 27));
            CrearNuevaInvitacion(invita19);

            //invitacion en estado RECHAZADA
            Invitacion invita20 = new Invitacion(_listaUsuarios[2] as Miembro, _listaUsuarios[3] as Miembro, "rechazada", new DateTime(2020, 03, 03));
            CrearNuevaInvitacion(invita20);

            //invitacion en estado PROCESO
            Invitacion invita21 = new Invitacion(_listaUsuarios[3] as Miembro, _listaUsuarios[4] as Miembro, "proceso", new DateTime(2022, 08, 08));
            CrearNuevaInvitacion(invita21);
        }

        ///NOTA: Algunos datos de estos post, fueron generados por ChatGPT y modificados 
        private void PrecargarPosts()
        {
            //Post [0]
            Post post1 = new Post("vacaciones en Miami", new DateTime(2018, 08, 08), _listaUsuarios[0] as Miembro, "primavera en USA", "img.jpg", "privado", false);
            CrearNuevoPost(post1);
            //Post [1]
            Post post2 = new Post("Recuerdos de París", new DateTime(2019, 06, 15), _listaUsuarios[1] as Miembro, "Días inolvidables en la Ciudad del Amor. 💖", "paris.jpg", "publico", false);
            CrearNuevoPost(post2);
            //Post [2]
            Post post3 = new Post("Aventuras en Tailandia", new DateTime(2020, 07, 25), _listaUsuarios[2] as Miembro, "Explorando la belleza de Tailandia. 🌴🌞", "tailandia.jpg", "publico", false);
            CrearNuevoPost(post3);
            //Post [3]
            Post post4 = new Post("Excursión a Machu Picchu", new DateTime(2021, 09, 10), _listaUsuarios[3] as Miembro, "Un sueño hecho realidad en las alturas de Perú. 🏞️", "machupicchu.jpg", "publico", false);
            CrearNuevoPost(post4);
            //Post [4]
            Post post5 = new Post("Noche de concierto en Nueva York", new DateTime(2022, 07, 03), _listaUsuarios[4] as Miembro, "Vibrando al ritmo de la Gran Manzana. 🎶🗽", "nyconcert.jpg", "publico", false);
            CrearNuevoPost(post5);
        }

        ///NOTA: Generados por ChatGPT 
        private void PrecargarComentarios()
        {
            //Post [0]
            Comentario comentario1 = new Comentario(_listaPubicaciones[0] as Post, "¡Wow, esta foto es simplemente impresionante! 😍", new DateTime(2023, 01, 08), _listaUsuarios[1] as Miembro, "foto divi", false);
            CrearNuevoComentario(comentario1);
            Comentario comentario2 = new Comentario(_listaPubicaciones[0] as Post, "¡¿Dónde tomaste esta increíble imagen? 😮", new DateTime(2023, 01, 09), _listaUsuarios[1] as Miembro, "foton", false);
            CrearNuevoComentario(comentario2);
            Comentario comentario3 = new Comentario(_listaPubicaciones[0] as Post, "¡Qué lugar tan hermoso! Me encantaría visitarlo algún día. 🌴☀️", new DateTime(2023, 02, 08), _listaUsuarios[1] as Miembro, "hermoso", false);
            CrearNuevoComentario(comentario3);
            //Post [1]
            Comentario comentario4 = new Comentario(_listaPubicaciones[1] as Post, "La naturaleza siempre nos sorprende con su belleza. 🍃💖", new DateTime(2023, 03, 08), _listaUsuarios[2] as Miembro, "belleza", false);
            CrearNuevoComentario(comentario4);
            Comentario comentario5 = new Comentario(_listaPubicaciones[1] as Post, "No puedo evitar envidiar tu talento para la fotografía. 📷💫", new DateTime(2023, 04, 08), _listaUsuarios[2] as Miembro, "talentoso", false);
            CrearNuevoComentario(comentario5);
            Comentario comentario6 = new Comentario(_listaPubicaciones[1] as Post, "Esa puesta de sol es simplemente mágica. ✨🌅", new DateTime(2023, 04, 08), _listaUsuarios[2] as Miembro, "magic", false);
            CrearNuevoComentario(comentario6);
            //Post [2]
            Comentario comentario7 = new Comentario(_listaPubicaciones[2] as Post, "Qué foto tan relajante! Me hace sentir en paz. 🌿🌊", new DateTime(2023, 03, 08), _listaUsuarios[1] as Miembro, "peace", false);
            CrearNuevoComentario(comentario7);
            Comentario comentario8 = new Comentario(_listaPubicaciones[2] as Post, "Estoy obsesionado/a con tus fotos, siempre son asombrosas. 📸👏", new DateTime(2023, 04, 08), _listaUsuarios[1] as Miembro, "awesome", false);
            CrearNuevoComentario(comentario8);
            Comentario comentario9 = new Comentario(_listaPubicaciones[2] as Post, "Esa sonrisa tuya ilumina la foto. 😄💕", new DateTime(2023, 04, 08), _listaUsuarios[1] as Miembro, "smile", false);
            CrearNuevoComentario(comentario9);
            //Post [3]
            Comentario comentario10 = new Comentario(_listaPubicaciones[3] as Post, "¡Estás viviendo la vida al máximo! 🙌", new DateTime(2023, 03, 08), _listaUsuarios[1] as Miembro, "max", false);
            CrearNuevoComentario(comentario10);
            Comentario comentario11 = new Comentario(_listaPubicaciones[3] as Post, "¿Cuál es el secreto para verte tan bien en todas tus fotos? 😁", new DateTime(2023, 04, 08), _listaUsuarios[1] as Miembro, "divi", false);
            CrearNuevoComentario(comentario11);
            Comentario comentario12 = new Comentario(_listaPubicaciones[3] as Post, "Esta imagen me transporta a otro mundo. 🚀🌌", new DateTime(2023, 04, 08), _listaUsuarios[1] as Miembro, "mundo", false);
            CrearNuevoComentario(comentario12);
            //Post [4]
            Comentario comentario13 = new Comentario(_listaPubicaciones[4] as Post, "La naturaleza siempre nos sorprende con su belleza. 🍃💖", new DateTime(2023, 03, 08), _listaUsuarios[3] as Miembro, "belleza", false);
            CrearNuevoComentario(comentario13);
            Comentario comentario14 = new Comentario(_listaPubicaciones[4] as Post, "No puedo evitar envidiar tu talento para la fotografía. 📷💫", new DateTime(2023, 04, 08), _listaUsuarios[3] as Miembro, "talentoso", false);
            CrearNuevoComentario(comentario14);
            Comentario comentario15 = new Comentario(_listaPubicaciones[4] as Post, "No puedo evitar envidiar tu talento para la fotografía. 📷💫", new DateTime(2023, 04, 08), _listaUsuarios[3] as Miembro, "talentoso", false);
            CrearNuevoComentario(comentario15);
        }

        private void PrecargarReacciones() //like o dislike
        {
            //reacciones a Post
            Reaccion reaccion1 = new Reaccion("like", _listaUsuarios[1] as Miembro, _listaPubicaciones[0] as Post);
            CrearNuevaReaccion(reaccion1);
            Reaccion reaccion2 = new Reaccion("like", _listaUsuarios[1] as Miembro, _listaPubicaciones[2] as Post);
            CrearNuevaReaccion(reaccion2);
            //reacciones a Comentarios
            Reaccion reaccion3 = new Reaccion("like", _listaUsuarios[2] as Miembro, _listaPubicaciones[3] as Post);
            CrearNuevaReaccion(reaccion3);
            Reaccion reaccion4 = new Reaccion("dislike", _listaUsuarios[3] as Miembro, _listaPubicaciones[4] as Post);
            CrearNuevaReaccion(reaccion4);
        }
        
        //END -------------PRECARGA DE DATOS------------


        //LOGIN USUARIO
        public string Login(string email, string pass)
        {
            string mensaje = "Error de sistema";
            if (ExisteEmail(email))
            {
                if (VerificarPass(email, pass))
                {
                    mensaje = "Login Correcto!";
                }
                else
                {
                    mensaje = "La password ingresada no coincide! Intente nuevamente";
                }
            }
            else
            {
                mensaje = "El mail ingresado no existe! Intente nuevamente";
            }
            return mensaje;
        }

        private bool ExisteEmail(string email)
        {
            bool existe = false;
            foreach (Usuario usu in _listaUsuarios)
            {
                if (usu.Email == email)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private bool VerificarPass(string email, string pass)
        {
            bool existe = false;
            foreach (Usuario usu in _listaUsuarios)
            {
                if (usu.Email == email)
                {
                    if (usu.Password == pass)
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }
        //END LOGIN USUARIO


        //CREAR NUEVO ADMINISTRADOR
        public string CrearNuevoAdministrador(Administrador administrador)
        {
            if (administrador == null)
            {
                throw new Exception("El admin recibido esta vacio.");
            }
            if (administrador is Administrador)
            {
                throw new Exception($"El usuario tiene que ser de tipo Administrador");
            }
            if (_listaUsuarios.Contains(administrador))
            {
                throw new Exception($"El admin ya existe.");
            }
            administrador.ValidarAdmin();
            _listaUsuarios.Add(administrador);
            return "Se creo el miembro correctamente";
        }
        //END CREAR NUEVO ADMINISTRADOR

        //CREAR NUEVA INVITACION
        public void CrearNuevaInvitacion(Invitacion invitacion)
        {
            if (invitacion.MiembroSolicitado is Miembro && invitacion.MiembroSolicitante is Miembro)
            {
                throw new Exception($"Los usuarios tienen que ser de tipo Miembro para crear una invitacion");
            }
            if (_listaInvitaciones.Contains(invitacion))
            {
                throw new Exception($"La invitacion ya existe");
            }
            invitacion.ValidarInvitacion();
            _listaInvitaciones.Add(invitacion);
        }
        //END CREAR NUEVA INVITACION

        //CREAR NUEVO POST
        public void CrearNuevoPost(Post post)
        {
            if (post.Miembro is Miembro)
            {
                throw new Exception($"El usuario tiene que ser de tipo Miembro para crear un Post");
            }
            if (_listaPubicaciones.Contains(post))
            {
                throw new Exception($"El Post ya fue publicado");
            }
            post.ValidarPost();
            _listaPubicaciones.Add(post);
        }
        //END CREAR NUEVO POST


        //CREAR NUEVO COMENTARIO
        public void CrearNuevoComentario(Comentario coment)
        {
            if (coment.Miembro is Miembro)
            {
                throw new Exception($"El usuario tiene que ser de tipo Miembro para crear un Comentario");
            }
            if (_listaPubicaciones.Contains(coment))
            {
                throw new Exception($"El Comentario ya fue publicado");
            }
            coment.ValidarComentario();
            _listaPubicaciones.Add(coment);
        }
        //END CREAR NUEVO COMENTARIO


        //CREAR NUEVA REACCION
        public void CrearNuevaReaccion(Reaccion react)
        {
            if (react.Miembro is Miembro)
            {
                throw new Exception($"El usuario tiene que ser de tipo Miembro para reaccionar");
            }
            if (_listaReacciones.Contains(react))
            {
                throw new Exception($"Ya existe reaccion");
            }
            react.ValidarReaccion();
            _listaReacciones.Add(react);
        }
        //END CREAR NUEVA REACCION

        //OBTENER MIEMBRO
        public Miembro ObtenerMiembro(string email)
        {
            Miembro? miembro = null;
            foreach (Miembro miem in _listaUsuarios)
            {
                if (miem.Email == email)
                {
                    miembro = miem;
                    break;
                }
            }
            return miembro;
        }
        //END OBTENER MIEMBRO











        //P1) CREAR NUEVO MIEMBRO
        public string CrearNuevoMiembro(Miembro miembro)
        {
            
            if (miembro == null)
            {
                throw new Exception("El miembro recibido esta vacio.");
            }
            if (_listaUsuarios.Contains(miembro))
            {
                throw new Exception($"El miembro ya existe."); 
            }
            miembro.ValidarMiembro();
            _listaUsuarios.Add(miembro);
            return "Se creo el miembro correctamente";
        }
        //END P1) CREAR NUEVO MIEMBRO


        //P2) listar todas las publicaciones de un MIEMBRO


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Publicacion> ListarPublicaciones(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new Exception("Hubo un error en el pasaje de datos del email");
                }

                Usuario.ValidarEmail(email);
                List<Publicacion> listaAux = new List<Publicacion>();

                Miembro? miembro = ObtenerMiembro(email);

                if (miembro != null)
                {
                    foreach (Publicacion unapub in _listaPubicaciones)
                    {
                        if (unapub.Miembro == miembro)
                        {
                            listaAux.Add(unapub);
                        }
                    }
                }
                else
                {
                    throw new Exception("El miembro no existe");
                }

                return listaAux;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        //END P2) listar todas las publicaciones de un MIEMBRO


        //P3) listar todas los post haya realizado comentarios
        
        public List<Post> ListarPost(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new Exception("Hubo un error en el pasaje de datos del email");
                }

                Usuario.ValidarEmail(email);
                List<Post> listaAux = new List<Post>();

                Miembro? miembro = ObtenerMiembro(email);

                if (miembro != null)
                {
                    foreach (Publicacion unPub in _listaPubicaciones)
                    {
                        if (unPub.Miembro == miembro && unPub is Comentario)
                        {
                            Comentario unComentario = (Comentario)unPub;
                            listaAux.Add(unComentario.Post);
                        }
                    }
                }
                else
                {
                    throw new Exception("Miembro no existe");
                }


                return listaAux;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //END P3) listar todas las publicaciones de un MIEMBRO


        // P4) Listar entre dos fechas todos los Posts
        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public List<Post> ListarPostFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if (fechaInicio == DateTime.MinValue && fechaFin == DateTime.MinValue)
                {
                    throw new Exception("Hubo un error en pasajes de fechas");
                }

                List<Post> listaAux = new List<Post>();

                foreach (Publicacion unPub in _listaPubicaciones)
                {
                    if (unPub is Post post && post.Fecha >= fechaInicio && post.Fecha <= fechaFin)
                    {
                        listaAux.Add(post);
                    }
                }

                // Ordenar los posts por título en forma descendente usando una función de comparación lambda
                listaAux.Sort((post1, post2) => string.Compare(post2.Titulo, post1.Titulo));


                return listaAux;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        //END P4) listar todas los post haya realizado comentarios


        // P5) Obtener los miembros que haya realizado mas publicaciones de cualquier tipo
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CantidadPublicaciones(string mail)
        {
            int cant = 0;
            foreach (Publicacion pub in _listaPubicaciones)
            {
                if (pub.Miembro.Email == mail)
                {
                    cant++;
                }
            }
            return cant;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Miembro> MiembrosMasPublicaciones()
        {
            List<Miembro> listaAux = new List<Miembro>(); 
            int cantidadPublicacionesMax = 0;

            foreach (Usuario usu in _listaUsuarios)
            {
                if (usu is Miembro) {
                    Miembro miem = (Miembro)usu;
                    int cantidadPublicacionesMiembro = CantidadPublicaciones(miem.Email);
                    if (cantidadPublicacionesMiembro > cantidadPublicacionesMax)
                    {
                        cantidadPublicacionesMax = cantidadPublicacionesMiembro;    //guardo la maxima cantidad de Publicaciones
                    }

                }

            }

            foreach (Usuario usu in _listaUsuarios){ //recorro la lista de nuevo para añadir a los miembros con mas pub a la lista

                if (usu is Miembro){
                    Miembro miem = (Miembro)usu;
                    int cantidadPublicacionesMiembro = CantidadPublicaciones(miem.Email);
                    if (cantidadPublicacionesMiembro == cantidadPublicacionesMax)
                    {
                        listaAux.Add(miem);
                    }
                }
            }

            return listaAux;

        }
        //END P5) Obtener los miembros que haya realizado mas publicaciones de cualquier tipo

        
    }
}
