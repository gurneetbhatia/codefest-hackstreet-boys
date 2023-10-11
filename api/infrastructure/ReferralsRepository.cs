using Domain;
using Domain.Interfaces;
using Newtonsoft.Json.Linq;

namespace Infrastructure;

public class ReferralsRepository : IReferralsRepository
{
    private readonly HackstreetDbContext _context;

    public ReferralsRepository(HackstreetDbContext context)
    {
        _context = context;
    }

    public List<Referral> Get(int referralId)
    {
        return _context.Referrals.Where(x => x.ReferralID == referralId).ToList();
    }

    public int Update(int referralId, JObject referralJsonObject)
    {
        var referral = referralJsonObject.ToObject<Referral>();

        if (referral == null) return 0;

        var patient = _context.Patients.SingleOrDefault(x => x.FirstName == referral.FirstName && x.LastName == referral.LastName && x.DOB == referral.DOB);

        if (patient != null)
        {
            referral.Exists = true;
        }
        else
        {
            referral.Exists = false;

            _context.Patients.Add(new Patient
            {
                FirstName = referral.FirstName,
                LastName = referral.LastName,
                Address = referral.Address,
                Email = referral.Email,
                DOB = referral.DOB
            };
        }

        _context.Referrals.Add(referral);

        return _context.SaveChanges();
    }

}
