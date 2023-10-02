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
            ValidarAdmin();
        }

        /// <summary>
        ///     Llama el validar del padre 
        /// </summary>
        public void ValidarAdmin()
        {
            base.Validar();
        }

        

    }
}
