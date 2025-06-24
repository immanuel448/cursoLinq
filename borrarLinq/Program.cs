using System.Runtime.CompilerServices;

namespace borrarLinq
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //fuente de datos estática
            List<Estudiantes> estudiantes = new List<Estudiantes>()
            {
                new Estudiantes{ Id = 1, Nombre = "Nadia", Edad = 19, Carrera ="Medicina" },
                new Estudiantes{ Id = 2, Nombre = "Iker", Edad = 20, Carrera ="Ingeniería" },
                new Estudiantes{ Id = 3, Nombre = "Armando", Edad = 18, Carrera ="Derecho" },
                new Estudiantes{ Id = 4, Nombre = "Erika", Edad = 22, Carrera ="Arquitectura" },
                new Estudiantes{ Id = 5, Nombre = "Oldair", Edad = 20, Carrera ="Ingeniería" }
            };

            //LINQ-----------------------
            //where, filtrar datos
            var estudiantesIngenieria =
                estudiantes.Where(e => e.Carrera == "ingeniería");
            Console.WriteLine($"\nLos estudiantes que estudian ingeniería son:");
            foreach (var item in estudiantesIngenieria)
            {
                Console.WriteLine($"-{item.Nombre} con {item.Edad} años.");
            }
            
            //select, elegir los datos para mostrar
            var soloNombres = estudiantes.Select(e => e.Nombre);
            Console.WriteLine($"\nSolo nombres de los estudiantes:");
            foreach (var nombre in soloNombres)
            {
                Console.WriteLine($"-{nombre}.");
            }

            //orderBy, ordenamiento lógico (orden ascendente)
            var ordenarEdadAscendente = estudiantes.OrderBy(e => e.Edad);
            Console.WriteLine($"\nOrdenar estudiantes por edad ascendente:");
            foreach (var estudiante in ordenarEdadAscendente)
            {
                Console.WriteLine($"-{estudiante.Nombre} de {estudiante.Edad} años, estudiante de {estudiante.Carrera}.");
            }

            //OrderByDescending, ordenamiento lógico (orden descendente)
            var ordenarEdadDescendente = estudiantes.OrderByDescending(e => e.Edad);
            Console.WriteLine($"\nOrdenar estudiantes por edad descendente:");
            foreach (var estudiante in ordenarEdadDescendente)
            {
                Console.WriteLine($"-{estudiante.Nombre} de {estudiante.Edad} años, estudiante de {estudiante.Carrera}.");
            }









            Console.ReadKey();
        }
    }
}
