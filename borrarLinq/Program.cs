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
                new Estudiantes{ Id = 3, Nombre = "Armando", Edad = 18, Carrera ="Abogacía" },
                new Estudiantes{ Id = 4, Nombre = "Erika", Edad = 22, Carrera ="Arquitectura" },
                new Estudiantes{ Id = 5, Nombre = "Oldair", Edad = 20, Carrera ="Ingeniería" }
            };

            //LINQ-----------------------
            //where
            Console.WriteLine("\nSELECCIONE LA CARRERA PARA BUSCAR:");
            string carreraElegida = Console.ReadLine();
            var estudiantesDeLaCarrera = estudiantes
                .Where(e => string.Equals(e.Carrera, carreraElegida, StringComparison.OrdinalIgnoreCase));

            if (estudiantesDeLaCarrera.Any())
            {
                //se encontraron resultados
                Console.WriteLine($"Los estudiantes que estudian {carreraElegida} son:");
                foreach (var item in estudiantesDeLaCarrera)
                {
                    Console.WriteLine($"{item.Nombre} con {item.Edad} años.");
                }
            }
            else
            {
                Console.WriteLine($"No hay estudiantes con la carrera de {carreraElegida}");
            }

            //select
            var soloNombres = estudiantes
                .OrderBy(e => e.Nombre)
                .Select(e => e.Nombre);
            Console.WriteLine($"\nSolo nombres de los estudiantes:");
            foreach (var item in soloNombres)
            {
                Console.WriteLine($"-{item}.");
            }

            //orderBy
            string eleccion = "";
            while (eleccion != "1" && eleccion != "2")
            {
                Console.WriteLine("\nSELECCIONE:");
                Console.WriteLine("(1) PARA ORDEN ASCENDENTE");
                Console.WriteLine("(2) PARA ORDEN DESCENDENTE");
                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        var ordenarEdad = estudiantes.OrderBy(e => e.Edad);
                        Console.WriteLine($"\nOrdenar estudiantes por edad ascendente:");
                        foreach (var item in ordenarEdad)
                        {
                            Console.WriteLine($"-{item.Nombre} de {item.Edad} años, estudiante de {item.Carrera}.");
                        }
                        break;
                    case "2":
                        ordenarEdad = estudiantes.OrderByDescending(e => e.Edad);
                        Console.WriteLine($"\nOrdenar estudiantes por edad descendente:");
                        foreach (var item in ordenarEdad)
                        {
                            Console.WriteLine($"-{item.Nombre} de {item.Edad} años, estudiante de {item.Carrera}.");
                        }
                        break;

                    default:
                        Console.WriteLine("Ha seleccionado una opción inválida!!!");
                        break;
                }
            }








            Console.ReadKey();
        }
    }
}
