using Microsoft.AspNetCore.Mvc;
using Referrals.Domain;
using Referrals.Domain.Interfaces;

namespace Referrals.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ReferralsController : ControllerBase
{
    private readonly ILogger<ReferralsController> _logger;
    private readonly IReferralsRepository _repo;

    public ReferralsController(ILogger<ReferralsController> logger, IReferralsRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpGet(Name = "Get")]
    public IEnumerable<Referral> Get()
    {
        return new List<Referral>();
    }
}