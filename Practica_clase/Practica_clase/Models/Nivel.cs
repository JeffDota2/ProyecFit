using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_clase.Models
{
    [Authorize]
    public class Nivel
    {
        public int Id { get; set; }
        public string TipoNivel { get; set; }
        public int Tiempo { get; set; }
    }
}
