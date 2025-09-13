using CursosLibres.Data;
using CursosLibres.Models;

namespace CursosLibres
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			InMemoryDb.Alumnos.AddRange(new[]{
				new Alumno{ Nombre="Ana", Email="ana@ejemplo.com" },
				new Alumno{ Nombre="Luis", Email="luis@ejemplo.com" },
			});
            InMemoryDb.Docentes.AddRange(new[]{
                new Docente { Nombre="Ing. Sandoval", Especialidad="Programación" },
                new Docente { Nombre="Lic. Julio", Especialidad="Física" },
                new Docente { Nombre = "Lic. Rivera", Especialidad = "Diseño Gráfico" },
        });

            var d = InMemoryDb.Docentes.FirstOrDefault(d => d.Nombre == "Ing. Sandoval");

            if (d != null)
            {
                var c1 = new CursoPresencial("C# desde 0", "Programación", 20, 0, d, "Campus Central", "B-201");
                c1.Sesiones.Add(new Sesion(DateTime.Today.AddHours(18), TimeSpan.FromHours(2)));

                var c2 = new CursoVirtual("Git y GitHub", "Herramientas", 15, 0, d, "Teams", new Uri("https://teams.link/curso"));
                c2.Sesiones.Add(new Sesion(DateTime.Today.AddHours(19), TimeSpan.FromHours(1.5)));

                InMemoryDb.Cursos.AddRange(new Curso[] { c1, c2 });
            }



            ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
	}
}