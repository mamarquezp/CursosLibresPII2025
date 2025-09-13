using CursosLibres.Data;
using CursosLibres.Models;
using System.Collections.Generic;
using System.Linq;

namespace CursosLibres.Controllers
{
    public class AlumnosController
    {
        public void Crear(string nombre, string email)
        {
            InMemoryDb.Alumnos.Add(new Alumno { Nombre = nombre, Email = email });
        }

        public List<Alumno> ObtenerTodos()
        {
            return InMemoryDb.Alumnos;
        }

        public List<Alumno> ObtenerPaginado(string busqueda, int pagina, int registrosPorPagina, out int totalRegistros)
        {
            var alumnosFiltrados = InMemoryDb.Alumnos
                .Where(a => string.IsNullOrEmpty(busqueda) ||
                            a.Nombre.ToLower().Contains(busqueda.ToLower()) ||
                            a.Email.ToLower().Contains(busqueda.ToLower()))
                .ToList();

            totalRegistros = alumnosFiltrados.Count;

            return alumnosFiltrados
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToList();
        }
    }
}