using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ
{
    public static class Inicializador
    {
        public static List<Estudiante> ObtenerEstudiantes()
        {
            return new List<Estudiante>
            {
                new Estudiante { Id = 1, Nombre = "Ana", Edad = 22, Carrera = "Ingeniería" },
                new Estudiante { Id = 2, Nombre = "Luis", Edad = 20, Carrera = "Medicina" },
                new Estudiante { Id = 3, Nombre = "Carlos", Edad = 19, Carrera = "Derecho" },
                new Estudiante { Id = 4, Nombre = "Lucía", Edad = 23, Carrera = "Ingeniería" },
                new Estudiante { Id = 5, Nombre = "María", Edad = 21, Carrera = "Arquitectura" }
            };
        }
    }
}
