using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
            {
                return _context.Eventos;
            }

       [HttpPut("{id}")]
        public Evento GetById(int id){
            return _context.Eventos.FirstOrDefault(
                Evento => Evento.Id ==id
                );
        }

        [HttpPost]
        public string Post(){
            return "Exemplo de POst";
        }
      }  
}
