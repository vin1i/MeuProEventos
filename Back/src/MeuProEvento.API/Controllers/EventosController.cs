using Microsoft.AspNetCore.Mvc;
using MeuProEvento.API.Models;
using System.Collections.Generic;
using MeuProEvento.API.Data;
using System.Linq;

namespace MeuProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> GetById(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(e => e.EventoId == id);

            if (evento == null)
            {
                return NotFound($"Nenhum evento encontrado com o ID {id}."); // Mensagem personalizada
            }

            return Ok(evento); // Retorna 200 OK com o evento encontrado
        }

        [HttpPost]
        public string Post()
        {
            return "Testando Post em api do C#";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}


// using Microsoft.AspNetCore.Mvc;
// using MeuProEvento.API.Models;
// using System.Collections.Generic;
// using MeuProEvento.API.Data;

// namespace MeuProEvento.API.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class EventoController : ControllerBase
//     {
     
//         private readonly DataContext _context;

//         public EventoController(DataContext context)
//         {
//             _context = context;
//         }

//         [HttpGet]
//         public IEnumerable<Evento> Get()
//         {
//             return _context.Eventos;
//         }


        
//  [HttpGet("{id}")]
// public ActionResult<Evento> GetById(int id)
// {
//     var evento = _context.Eventos.FirstOrDefault(e => e.EventoId == id);
    
//     if (evento == null)
//     {
//         return NotFound($"Nenhum evento encontrado com o ID {id}."); // Mensagem personalizada
//     }

//     else 
//     {
//         return Ok(evento); // Retorna 200 OK com o evento encontrado
//     }}



// /*----------------------------------------------*/

//         [HttpPost]
//         public string Post()
//         {
//             return "Testando Post em api do C#";
//         }

//         [HttpPut("{id}")]
//         public string Put(int id)
//         {
//             return $"Exemplo de Put com id = {id}";
//         }

//         [HttpDelete("{id}")]
//         public string Delete(int id)
//         {
//             return $"Exemplo de Delete com id = {id}";
//         }
//     }
// }
