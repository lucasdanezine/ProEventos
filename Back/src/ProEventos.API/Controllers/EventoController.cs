using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
           
        }

        public IEnumerable <Evento> _evento = new Evento[] { 
                
               new Evento(){
               EventoId = 1,
               Tema = "Angular 11 e .NET5",
               Local = "BH",
               Lote = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString()   
               },
                new Evento(){
               EventoId = 2,
               Tema = "Angular 11 e .NET5",
               Local = "BH",
               Lote = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString()   
               }
           
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut]
        public string Put(int id)
        {
           return "value" + id;
        }
    }
}
