using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventos.API.data;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        IEnumerable<Evento> _eventos = new Evento[]{
             new Evento(1,"ARACAJU",DateTime.Now.AddDays(5).ToString("dd/MM/yyy"),"Jesus Cristo", 1, 300, "image.ulr.com.br"),
             new Evento(2,"Nossa Senhora do socorro",DateTime.Now.AddDays(10).ToString("dd/MM/yyy"),"Deus é amor", 2, 200, "image.ulr.com.br"),
            new Evento(3,"Recife",DateTime.Now.AddDays(15).ToString("dd/MM/yyy"),"As escrituras sacadas", 3, 1000, "image.ulr.com.br"),
        };
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;


        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return context.Eventos.Where(evento => evento.EventoID == id);
        }
    }
}
