using Homework_6.Services.PeopleService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public PeoplesController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            return await _peopleService.GetPeople();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(Guid id)
        {
            var person = await _peopleService.GetPersonById(id);
            if (person == null)
                return NotFound("Sorry, but this hero is does't exist");
            return Ok(_peopleService);
        }

        [HttpPost]
        public async Task<ActionResult<List<Person>>> CreatePerson(CreatePersonRequest newPerson)
        {
            await _peopleService.CreatePerson(newPerson);
            return Ok(_peopleService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> RemovePersonById(Guid id)
        {
            var person = await _peopleService.RemovePersonById(id);
            if (person == null)
                return NotFound("Sorry, but this person is does't exist");

            return Ok(_peopleService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Person>>> UpdatePersonById(Guid id, Person request)
        {
            var person = await _peopleService.UpdatePersonById(id, request);
            if (person == null)
                return NotFound("Sorry, but this person is does't exist");

            return Ok(_peopleService);
        }
    }
}
