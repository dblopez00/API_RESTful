using Datos.ServicesWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_REST.Controllers
{
    public class LibroController : ApiController
    {
        LibreriaConnection BD = new LibreriaConnection();
        /// <summary>
        /// Permite consultar la informacion de todos los libros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            var listado = BD.Libro.ToList();
            return listado;
        }

        [HttpGet]
        public Libro Get(int id)
        {
            var libro = BD.Libro.FirstOrDefault(x=> x.id_libro == id);
            return libro;
        }
    }
}
