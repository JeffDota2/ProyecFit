﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_clase.Models
{
    [Authorize]
    public class CrearFicha
    {

        

        [Required]
        [Display(Name = "Debes ingresar tu Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Debes ingresar tu Apellido")]

        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Debes ingresar tu Celular")]

        public int Celular { get; set; }
        [Required]
        [Display(Name = "Debes ingresar tu Direccion")]

        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Debes ingresar tu Fecha de Nacimiento")]
 
        public DateTime FechaNacimiento { get; set; }
    }
}
