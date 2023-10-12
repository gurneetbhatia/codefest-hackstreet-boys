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

        [HttpPost("Login")]
        public ActionResult Login(string personType, string email)
        {
            switch (personType)
            {
                case "Employee":
                    var emp = _repo.GetEmployee(email);
                    if (emp != null)
                    {
                        return Ok(emp.Id);
                    }
                    return BadRequest();
                case "Patient":
                    var patient = _repo.GetPatient(email);
                    if (patient != null)
                    {
                        return Ok(patient.Id);
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
