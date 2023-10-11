using Microsoft.AspNetCore.Mvc;
using Appointments.Domain;
using Appointments.Domain.Interfaces;

namespace Appointments.API.Controllers;

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
    public async Task<bool> Update(int referralId, int statusId)
    {
        return true;
    }
}