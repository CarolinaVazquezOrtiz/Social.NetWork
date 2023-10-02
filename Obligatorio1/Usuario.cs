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

        /// <summary>
        ///     Esta funcion llama al Validar Email y al Validar Password
        /// </summary>
        public void Validar()
        {
            ValidarEmail(Email);
            ValidarPassword(Password);
        }

        /// <summary>
        ///     Esta funcion verifica mediante el Formato de Email que sea valido, en caso contrario larga una excepcion
        /// </summary>
        public static void ValidarEmail(string email)
        {
            if (!FormatoEmail(email))
            {
                throw new Exception("El Formato del email no es valido");
            }
        }

        /// <summary>
        ///     Esta funcion recibe un email el cual debe cumplir el formato con arroba y punto despues del domino del mail
        /// </summary>
        /// <returns>retorna true si cumple, en caso contrario false</returns>
        private static bool FormatoEmail(string email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, patron);
        }

        /// <summary>
        ///     Esta funcion verifica mediante el Formato de Password que sea valido, en caso contrario larga una excepcion
        /// </summary>
        public static void ValidarPassword(string pass)
        {
            if (!FormatoPass(pass))
            {
                throw new Exception ($"El Formato de la contraseña {pass} no es valido ");
            }
        }

        /// <summary>
        ///     Esta funcion recibe una password la cual debe cumplir que la contraseña tenga un largo entre 8 y 12 caracteres,
        ///     que contenga una minuscula , una mayuscula, un numero y un caracter especial; 
        /// </summary>
        /// <returns>retorna true si cumple, en caso contrario false</returns>
        private static bool FormatoPass(string pass)
        { 
            string patron = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%^&+=!*._-]).{8,12}$";
            return Regex.IsMatch(pass, patron);
        }

        
    }
}
