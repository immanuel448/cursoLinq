
using System.Globalization;

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
            //hola
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
            // WHERE: Permite filtrar elementos que cumplan una condición
            //var estudiantesDeIngenieria = estudiantes.Where(e => e.Carrera == "Ingeniería");
            //Console.WriteLine($"\n Where, Los estudiantes que estudian Ingeniería son:");
            //foreach (var estudiante in estudiantesDeIngenieria)
            //{
            //    Console.WriteLine($"{estudiante.Nombre} con {estudiante.Edad} años.");
            //}

            // SELECT: Proyecta cada elemento en una nueva forma (por ejemplo, seleccionar una propiedad)
            //var soloNombres = estudiantes.Select(e => e.Nombre);
            //Console.WriteLine($"\n Select, Solo nombres de los estudiantes:");
            //foreach (var estudiante in soloNombres)
            //{
            //    Console.WriteLine($"-{estudiante}.");
            //}

            // ORDERBY: Ordena los elementos en orden ascendente
            //var ordenarEdad = estudiantes.OrderBy(e => e.Edad);
            //Console.WriteLine($"\n OrderBy, Ordenar estudiantes por edad ascendente:");
            //foreach (var estudiante in ordenarEdad)
            //{
            //    Console.WriteLine($"-{estudiante.Nombre} de {estudiante.Edad} años, estudiante de {estudiante.Carrera}.");
            //}

            //ORDERBYDESCENDING: Ordena los elementos en orden descendente
            //ordenarEdad = estudiantes.OrderByDescending(e => e.Edad);
            //Console.WriteLine($"\n OrderByDescending, Ordenar estudiantes por edad descendente:");
            //foreach (var estudiante in ordenarEdad)
            //{
            //    Console.WriteLine($"-{estudiante.Nombre} de {estudiante.Edad} años, estudiante de {estudiante.Carrera}.");
            //}

            // GROUPBY: Agrupa elementos que tienen una misma clave
            //var conteoPorCarrera = estudiantes.GroupBy(e => e.Carrera == "Ingeniería");
            //Console.WriteLine("\nGROUPBY, Cantidad de estudiantes por carrera:");
            //foreach (var grupo in conteoPorCarrera)
            //{
            //    Console.WriteLine($"La carrera de {grupo.Key} tiene {grupo.Count()} estudiantes");
            //}

            // ANY: Devuelve true si al menos un elemento cumple una condición
            //var ciertaEdad = estudiantes.Any(e => e.Edad > 18);
            //Console.WriteLine($"\n Any, Saber si hay extudiantes mayores de 20 años:");
            //if (ciertaEdad)
            //{
            //    Console.WriteLine($"Sí hay al menos un estudiante mayor de 20 años.");
            //}
            //else
            //{
            //    Console.WriteLine($"No hay ningún estudiante mayor de 20 años.");
            //}

            // FIRSTORDEFAULT: Devuelve el primer elemento o un valor por defecto si no hay elementos
            //var primerEstudiante = estudiantes.OrderBy(e => e.Nombre).FirstOrDefault();
            //Console.WriteLine($"\n OrderBy y FirstOrDefault, nos devuelve el primer nombre ordenado alfabéticamente:");
            //Console.WriteLine($"El nombre del primer estudiante en orden alfabético es {primerEstudiante.Nombre}.");

            // AVERAGE: Calcula el promedio de los valores numéricos
            //var promedio = estudiantes.Average(e => e.Edad);
            //Console.WriteLine($"\nA verage, Se obtiene el promedio de la edad:");
            //Console.WriteLine($"El promedio de la edad de los estudientes es de {promedio} años.");

            // SELECT con objetos anónimos: Proyección personalizada de los datos
            //var resumen = estudiantes
            //    .Select(e => new
            //    {
            //        Nombre = e.Nombre.ToUpper(),
            //        Edad = e.Edad,
            //        Carrera = $"con la carrera de: {e.Carrera}"
            //    });
            //Console.WriteLine($"\n Select con fucniones anónimas :");
            //foreach (var estudiante in resumen)
            //{
            //    Console.WriteLine($"-El estudiante {estudiante.Nombre} de {estudiante.Edad} años, {estudiante.Carrera}.");
            //}

            Console.ReadKey();
        }
    }
}
