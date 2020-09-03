using Microsoft.AspNetCore.Authorization;
using System;

namespace Practica_clase.Models
{
    [Authorize]
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descipción { get; set; }
        public int NumeroRepeticiones { get; set; }
        public TimeSpan TiempoEstimado { get; set; }
        public string ruta { get; set; }

    }
}
