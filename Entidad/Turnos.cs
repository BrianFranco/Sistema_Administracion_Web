﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Turnos
    {
        //Attributes
        private int id;
        private String nombre;
        private String fechaBaja;
        private String causaBaja;
        //Constructors
        public Turnos(int id, string nombre, string fechaBaja, string causaBaja)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaBaja = fechaBaja;
            this.CausaBaja = causaBaja;
        }
        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string CausaBaja { get => causaBaja; set => causaBaja = value; }
    }
}
