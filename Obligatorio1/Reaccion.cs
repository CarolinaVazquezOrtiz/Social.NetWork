﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Reaccion
    {

        public string TipoReaccion { get; set; }

        public Miembro Miembro { get; set; }

        public Publicacion PublicacionReaccionada { get; set; }

        public Reaccion(string tipoReaccion, Miembro miembro, Publicacion publicacionReaccionada)
        {
            TipoReaccion = tipoReaccion;
            Miembro = miembro;
            PublicacionReaccionada = publicacionReaccionada;
            ValidarReaccion();
        }
        
        public void ValidarReaccion()
        {
            ValidarTipoReaccion();
        }

        public void ValidarTipoReaccion()
        {
            if (TipoReaccion.ToLower() != "like" && TipoReaccion.ToLower() != "dislike")
            {
                throw new Exception($"Tipo de reaccion: {TipoReaccion} no es valido");
            }
        }

       
    }
}
