
namespace  CursoLINQ
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
            //where
            var estudiantesDeIngenieria = estudiantes.Where(e => e.Carrera == "Ingeniería");
            Console.WriteLine($"\nWhere, Los estudiantes que estudian Ingeniería son:");
            foreach (var estudiante in estudiantesDeIngenieria)
            {
                Console.WriteLine($"{estudiante.Nombre} con {estudiante.Edad} años.");
            }

            //select
            var soloNombres = estudiantes.Select(e => e.Nombre);
            Console.WriteLine($"\nSelect, Solo nombres de los estudiantes:");
            foreach (var estudiante in soloNombres)
            {
                Console.WriteLine($"-{estudiante}.");
            }

            //orderBy, OrderByDescending
            var ordenarEdad = estudiantes.OrderBy(e => e.Edad);
            Console.WriteLine($"\nOrderBy, Ordenar estudiantes por edad ascendente:");
            foreach (var estudiante in ordenarEdad)
            {
                Console.WriteLine($"-{estudiante.Nombre} de {estudiante.Edad} años, estudiante de {estudiante.Carrera}.");
            }

            ordenarEdad = estudiantes.OrderByDescending(e => e.Edad);
            Console.WriteLine($"\nOrderByDescending, Ordenar estudiantes por edad descendente:");
            foreach (var item in ordenarEdad)
            {
                Console.WriteLine($"-{item.Nombre} de {item.Edad} años, estudiante de {item.Carrera}.");
            }







            Console.ReadKey();
        }
    }
}
