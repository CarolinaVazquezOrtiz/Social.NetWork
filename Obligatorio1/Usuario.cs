using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Usuario
    {
        //Datos
        public string Email { get; set; }
        public string Password { get; }
        public bool IsAdmin { get; set; }

        //Constructor
        public Usuario(string email, string password, bool isAdmin)
        {
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }


        public void Validar()
        {
            ValidarMail();
            ValidarPassword();
        }

        public static void ValidarMail()
        {

        }

        public static void ValidarPassword()
        {

        }


    }
}
