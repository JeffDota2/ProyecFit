using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_clase.Models
{
    [Authorize]
    public class Rutina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descipción { get; set; }
        public int Duracion { get; set; }


    }
}
