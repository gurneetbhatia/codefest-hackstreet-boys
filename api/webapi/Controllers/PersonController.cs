using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repo;

        public PersonController(IPersonRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Login(string personType, string email)
        {
            switch(personType)
            {
                case "Employee":
                    if(_repo.GetEmployee(email) != null)
                    {
                        return Ok();
                    }
                    return BadRequest();
                case "Patient":
                    if (_repo.GetPatient(email) != null)
                    {
                        return Ok();
                    }
                    return BadRequest();
            }

            return BadRequest();
        }

        //[HttpPost("Update")]
        //public async Task<IActionResult> Update(Person person)
        //{
        //    if (_repo.Update(person) > 0)
        //        return Ok();
        //    else
        //        return BadRequest();
        //}
    }
}
