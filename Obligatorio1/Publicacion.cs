﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{

    public abstract class Publicacion
    {
        //Static
        private static int autID;

        //Datos
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public Miembro Miembro { get; set; }
        public string Titulo { get; set; }

        //Constructor
        public Publicacion(string contenido, DateTime fecha, Miembro miembro, string titulo)
        {
            Id = ++autID;
            Contenido = contenido;
            Fecha = fecha;
            Miembro = miembro;
            Titulo = titulo;
            Validar();
        }

        //FALTA VALIDAR MIEMBRO
        public void Validar()
        {
            ValidarContenido(Contenido);
            ValidarTitulo(Titulo);
        }

        public static void ValidarContenido(string cont)
        {
            if (string.IsNullOrEmpty(cont))
            {
                throw new Exception("Contenido vacio");
            }
        }

        public static void ValidarTitulo(string tit)
        {
            if (string.IsNullOrEmpty(tit) && tit.Length < 3)
            {
                throw new Exception("El título debe contener al menos 3 caracteres");
            }
        }



    }
}
