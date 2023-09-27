using System;
using System.Collections.Generic;
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

        public  List<Usuario> ListaUsuarios { get { return _listaUsuarios; } }
        public  List<Invitacion> ListaInvitaciones { get { return _listaInvitaciones; } }
        public  List<Publicacion> ListaPublicaciones { get { return _listaPubicaciones; } }
        public  List<Reaccion> ListaReacciones { get { return _listaReacciones; } }



        //LOGIN USUARIO
        public string Login(string email, string pass)
        {
            string mensaje="Error de sistema";
            if (ExisteEmail(email))
            {
                if (VerificarPass(email,pass))
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


        //P1) CREAR NUEVO MIEMBRO
        public string CrearNuevoMiembro(Miembro miembro)
        {
            if (miembro == null)
            {
                throw new Exception("El mimebro recibido esta vacio.");
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




        //P2) listar todas las publicaciones de un MIEMBRO   -------revisar----
        public string ListarPublicaciones(String mail)
        {
            Usuario.ValidarEmail(mail);
            Miembro? miembro = null;
            String mensaje = "";

            foreach (Miembro miem in _listaUsuarios)
            {
                if (miem.Email.Contains(mail))
                {
                    miembro = miem;
                    break;
                }
            }

            if (miembro != null)
            {
                mensaje=$"Publicaciones de {miembro.Email}:";

                foreach (Publicacion publicacion in _listaPubicaciones)
                {
                    if (publicacion.Miembro == miembro)
                    {
                        if (publicacion is Post)
                        {
                            mensaje += $"Post: {publicacion.Titulo}";
                        }
                        else if (publicacion is Comentario)
                        {
                            mensaje += $"Comentario: {publicacion.Contenido}";
                        }
                    }
                }
            }

            //if (mensaje=Empty)
            //{

            //}

            return mensaje;

        }
        //END P2) listar todas las publicaciones de un MIEMBRO


        //P3) listar todas los post haya realizado comentarios   -------revisar----
        //END P3) listar todas las publicaciones de un MIEMBRO
    }
}
