using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Domain;
using Domain.Interfaces;

namespace API.Controllers;

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

    // get referral based on referralid
    [HttpGet("Get")]
    public async Task<List<Referral>> Get(int referralId)
    {
        return _repo.Get(referralId);
    }

    // admin user/therapist gets a referral and approves or rejects it via statusid
    // this method also handles creating new referral
    [HttpPost("Update")]
    public async Task<IActionResult> Update(int referralId, [FromForm]JObject formData)
    {
        if (_repo.Update(referralId, formData) > 0)
            return Ok();
        else
            return BadRequest();
    }
}