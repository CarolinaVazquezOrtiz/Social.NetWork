﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

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

        public void PrecargarMiembros()
        {
            Miembro miembro1 = new Miembro("caro19@gmail.com", "Estrellas-19", false, "Carolina", "Vazquez", new DateTime(1991, 10, 10));
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
        }
        public void PrecargarAdministradores()
        {
            Administrador admin1 = new Administrador("guille77@gmail.com", "Pluton-77", true);
            CrearNuevoAdministrador(admin1);
        }
        public void PrecargarInvitaciones()
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


        public void PrecargarPosts()    ///------------> TERMINAR CV --------
        {
            Post post1 = new Post("vacaciones en Miami", new DateTime(2022, 08, 08), _listaUsuarios[0] as Miembro, "primavera en USA", "img.jpg", "publico", false);
            //CrearNuevoPost(post1);
        }
        public void PrecargarComentarios()
        {

        }
        public void PrecargarReacciones()
        {

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
            if (_listaInvitaciones.Contains(invitacion))
            {
                throw new Exception($"La invitacion ya existe");
            }
            invitacion.ValidarInvitacion();
            _listaInvitaciones.Add(invitacion);
        }
        //END CREAR NUEVA INVITACION


        // FUNCIONALIDAD ADMINSTRADOR
        public void AdministradorBloquear(Miembro miembro)
        {

        }

        public void AdministradorDesbloquear(Miembro miembro)
        {

        }

        public void CensurarComentario(Publicacion publicacion)
        {

        }

        public void HabilitarComentario(Publicacion publicacion)
        {

        }

        // END FUNCIONALIDAD ADMINISTRADOR






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

        public List<Publicacion> ListarPubicaciones(string email)
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
        //public List<Post> ListarMiembrosCantidadPublicacion()
        //{
        //    // Calcular la cantidad de publicaciones de tipo Post y Comentario por miembro
        //    Dictionary<Miembro, int> publicacionesPostPorMiembro = new Dictionary<Miembro, int>();
        //    Dictionary<Miembro, int> publicacionesComentarioPorMiembro = new Dictionary<Miembro, int>();

        //    foreach (Publicacion publicacion in _listaPubicaciones)
        //    {
        //        if (publicacion is Post)
        //        {
        //            if (publicacionesPostPorMiembro.ContainsKey(publicacion.Miembro))
        //            {
        //                publicacionesPostPorMiembro[publicacion.Miembro]++;
        //            }
        //            else
        //            {
        //                publicacionesPostPorMiembro[publicacion.Miembro] = 1;
        //            }
        //        }
        //        else if (publicacion is Comentario)
        //        {
        //            if (publicacionesComentarioPorMiembro.ContainsKey(publicacion.Miembro))
        //            {
        //                publicacionesComentarioPorMiembro[publicacion.Miembro]++;
        //            }
        //            else
        //            {
        //                publicacionesComentarioPorMiembro[publicacion.Miembro] = 1;
        //            }
        //        }
        //    }
        //}

        //END P5) Obtener los miembros que haya realizado mas publicaciones de cualquier tipo

        public Miembro ObtenerMiembro(string mail)
        {
            Miembro? miembro = null;
            foreach (Miembro miem in _listaUsuarios)
            {
                if (miem.Email == mail)
                {
                    miembro = miem;
                    break;
                }
            }
            return miembro;
        }
    }
}
