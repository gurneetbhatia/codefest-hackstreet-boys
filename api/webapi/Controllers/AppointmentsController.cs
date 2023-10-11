using Microsoft.AspNetCore.Mvc;
using Appointments.Domain;
using Appointments.Domain.Interfaces;
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
    public async Task<List<Appointment>> Get(int patientId, int therapistId)
    {
        return new List<Appointment>();
    }

    // admin user/therapist can update details of appointment
    // this method also handles creating new appointments
    [HttpPost("Update")]
    public async Task<bool> Update(int apptId, [FromForm]JObject formData)
    {
        return true;
    }
}