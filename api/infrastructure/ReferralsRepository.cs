using Domain;
using Domain.Interfaces;

namespace Infrastructure;

public class ReferralsRepository : IReferralsRepository
{
    private readonly HackstreetDbContext _context;

    public ReferralsRepository(HackstreetDbContext context)
    {
        _context = context;
    }

    public List<Referral> Get(string firstName, string lastName, DateTime dob)
    {
        var id = PersonUniqueId(firstName, lastName, dob);
        return _context.Referrals.Where(x => x.Id == id).ToList();
    }

    public int Update(Referral referral)
    {
        //var referral = referralJsonObject.ToObject<Referral>();

        if (referral == null) return 0;

        var id = PersonUniqueId(referral.FirstName, referral.LastName, referral.DOB);

        var patient = _context.Patients.SingleOrDefault(x => x.Id == id);

        if (patient != null)
        {
            referral.PatientExists = true;
        }
        else
        {
            referral.Id = id;
            referral.PatientExists = false;

            _context.Patients.Add(new Patient
            {
                FirstName = referral.FirstName,
                LastName = referral.LastName,
                Address = referral.Address,
                Email = referral.Email,
                DOB = referral.DOB
            });
        }

        _context.Referrals.Add(referral);

        return _context.SaveChanges();
    }

    private string PersonUniqueId(string firstName, string lastName, DateTime dob)
    {
        return $"{firstName.ToUpper()}-{lastName.ToUpper()}-{dob:yyyyMMdd}";
    }

}
