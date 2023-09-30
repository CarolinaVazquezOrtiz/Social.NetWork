using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Usuario
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
            Validar();
        }


        public void Validar()
        {
            ValidarEmail(Email);
            ValidarPassword(Password);
        }

        public static void ValidarEmail(string email)
        {
            if (!FormatoEmail(email))
            {
                throw new Exception("El Formato del email no es valido");
            }
        }

        private static bool FormatoEmail(String email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, patron);
        }

        public static void ValidarPassword(string pass)
        {
            if (!FormatoPass(pass))
            {
                throw new Exception ($"El Formato de la contraseña {pass} no es valido ");
            }
        }

        private static bool FormatoPass(string pass)
        {
            // Define una expresión regular que cumple con los requisitos.
            //asumimos contrase;a largo entre 8 y 12 caracteres, que contenga una min, una may, un numero y un caracter especial; 
            string patron = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%^&+=!*._-]).{8,12}$";
            return Regex.IsMatch(pass, patron);
        }

        
    }
}
