using Microsoft.AspNetCore.Mvc;
using Back.src.Proventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    [HttpGet]
    public IEnumerable<Evento> Get(int id)
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        //return _evento.Where(evento -> Evento.EventoID == id);
        return null;
    }

    public IEnumerable<Evento> _evento = new Evento[] 
    {
            new Evento() 
            {

                EventoID = 1,
                Tema = "Angular 11 e .NET 6",
                Local = "Ourinhos",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"

            },

            new Evento() 
            {

                EventoID = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL = "foto.png"
            
            }
    };
}
