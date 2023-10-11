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

        // update
        if (_context.Referrals.Any(x => x.ReferralID == referralId))
            _context.Referrals.Update(referral);

        // create
        _context.Referrals.Add(referral);

        return _context.SaveChanges();
    }

}
