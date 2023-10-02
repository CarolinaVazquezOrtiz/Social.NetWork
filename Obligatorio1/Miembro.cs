using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Obligatorio1
{
    public class Miembro:Usuario
    {

        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public DateTime FechaNac { get; set; }

        public bool Bloqueado { get;  set; }
        
        private List<Miembro> _listaAmigos = new List<Miembro>();

        public Miembro(string email, string password, bool isAdmin, string nombre, string apellido, DateTime fechaNac)
        :base(email,password,isAdmin)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Bloqueado = false;
            ValidarMiembro();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ValidarMiembro()
        {
            base.Validar();
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new Exception("El nombre está vacío");
            }
            if (string.IsNullOrWhiteSpace(Apellido))
            {
                throw new Exception("El apellido está vacío");
            }
        }
        


    }
}
