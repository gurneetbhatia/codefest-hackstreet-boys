using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Interfaces;
using Newtonsoft.Json.Linq;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly ILogger<AppointmentsController> _logger;
    private readonly IAppointmentsRepository _repo;

    public AppointmentsController(ILogger<AppointmentsController> logger, IAppointmentsRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    // get appointments for a specific patient or therapist
    [HttpGet("Get")]
    public async Task<List<Appointment>> Get(string patientId, string therapistId)
    {
        return _repo.Get(patientId, therapistId);
    }

    // admin user/therapist can update details of appointment
    // this method also handles creating new appointments
    [HttpPost("Update")]
    public async Task<IActionResult> Update(Appointment appt)
    {
        if (_repo.Update(appt) > 0)
            return Ok();
        else
            return BadRequest();
    }
}