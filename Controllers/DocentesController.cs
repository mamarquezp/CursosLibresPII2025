using CursosLibres.Data;
using CursosLibres.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosLibres.Controllers
{
    public class DocentesController
    {
        public void Crear(string nombre, string especialidad)

        {
            InMemoryDb.Docentes.Add(new Docente { Nombre = nombre, Especialidad = especialidad });
        }

        public List<Docente> ObtenerTodos()
        {
            return InMemoryDb.Docentes;
        }
    }
}
