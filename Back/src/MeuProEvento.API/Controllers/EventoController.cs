using Microsoft.AspNetCore.Mvc;
using MeuProEvento.API.Models;
using System.Collections.Generic;

namespace MeuProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento
            {
                EventoId = 1,
                Local = "Teresina-PI",
                DataEvento = DateTime.Now.AddDays(8).ToString("dd-MM-yyyy"),
                Tema = "Teste API",
                QtdPessoas = 100,
                Lote = "1º Lote",
                ImagemURL = "imagem.jpg"
            },
            new Evento
            {
                EventoId = 2,
                Local = "São Luís-MA",
                DataEvento = DateTime.Now.AddDays(15).ToString("dd-MM-yyyy"),
                Tema = "Outro Teste API",
                QtdPessoas = 200,
                Lote = "2º Lote",
                ImagemURL = "outra_imagem.jpg"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }


        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }



/*----------------------------------------------*/

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
