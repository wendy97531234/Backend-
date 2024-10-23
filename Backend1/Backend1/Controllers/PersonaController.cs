using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet("all")]
        public List<PersonaDatos> GetPersonaDatos() => Repository.persona;

        [HttpGet("{Id}")]
        public PersonaDatos getPersonaDatos(int Id) => Repository.persona.FirstOrDefault(p=>p.Id == Id);

        [HttpGet("Search/{search}")]
         public List<PersonaDatos> Get(string search) =>
            Repository.persona.Where(p=> p.Name.ToUpper().Contains(search.ToUpper())).ToList();

    }
   
}
