using Demo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class SolicitudController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly DemoContext _context;

        public SolicitudController(DemoContext context, IRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        [HttpGet("Get")]
        public async Task<ActionResult> GetSolicitudes()
        {
            Respuesta<object> respuesta = new();

            var q =  await _repository.SelectAll<Solicitude>();

            foreach (var item in q)
            {
                respuesta.Data.Add(item);
            }
            
            return Ok(respuesta);
        }
    }

}
