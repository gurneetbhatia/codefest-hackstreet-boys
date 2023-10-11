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

    [HttpGet(Name = "Get")]
    public IEnumerable<Appointment> Get()
    {
        return new List<Appointment>();
    }
}