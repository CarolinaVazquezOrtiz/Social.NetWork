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
            Usuario usuario1 = new Miembro("caro19@gmail.com","Estrellas-19",false,"Carolina","Vazquez", new DateTime(1991, 10, 10) );
            CrearNuevoMiembro(usuario1);
            Usuario usuario2 = new Miembro("sofia88@gmail.com","Lunas-88",false,"Sofia","Ortiz", new DateTime(1988, 10, 03) );
            CrearNuevoMiembro(usuario2); 
        }
        public void PrecargarAdministradores()
        {
            Usuario admin1 = new Administrador("guille77@gmail.com", "Pluton-77", true);
            CrearNuevoAdministrador(admin1);
        }
        public void PrecargarInvitaciones()
        {

        }
        public void PrecargarPosts()
        {

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




        //P2) listar todas las publicaciones de un MIEMBRO  
        public List<Publicacion> ListarPubicaciones(String mail)
        {
            Usuario.ValidarEmail(mail);
            List<Publicacion> listaAux = new List<Publicacion>();
            Miembro? miembro = null;

            foreach (Miembro miem in _listaUsuarios)
            {
                if (miem.Email == mail)
                {
                    miembro = miem;
                    break;
                }
            }

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

            if (miembro == null)
            {
                throw new Exception("Miembro no existe");
            }

            return listaAux;
        }
        //END P2) listar todas las publicaciones de un MIEMBRO


        //P3) listar todas los post haya realizado comentarios   -------revisar----
        //END P3) listar todas las publicaciones de un MIEMBRO
    }
}
