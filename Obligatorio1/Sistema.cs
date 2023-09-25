using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
