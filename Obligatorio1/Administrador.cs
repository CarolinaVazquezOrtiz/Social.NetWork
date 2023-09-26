using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Administrador:Usuario
    {
        public Administrador(string email, string password, bool isAdmin)
        :base(email,password,isAdmin) 
        {

        }

        public void AdministradorBloquear()
        {

        }

        public void AdministradorDesbloquear()
        {

        }

        public void CensurarComentario()
        {

        }

        public void HabilitarComentario()
        {

        }

    }
}
