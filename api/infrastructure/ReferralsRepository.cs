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

    public string Update(Referral referral)
    {
        if (referral == null) return "Invalid referral object";

        var personUid = PersonUniqueId(referral.FirstName, referral.LastName, referral.DOB);

        var patient = _context.Patients.SingleOrDefault(x => x.Id == personUid);

        if (patient != null)
        {
            referral.PatientExists = true;
        }
        else
        {
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

        var existingReferral = _context.Referrals.SingleOrDefault(x => x.FirstName == referral.FirstName && x.LastName == referral.LastName && x.DOB == referral.DOB);

        if (existingReferral == null)
            _context.Referrals.Add(referral);
        else
            return $"Referral already exists for {referral.FirstName} {referral.LastName}.";

        if(_context.SaveChanges() > 0)
        {
            return "Referral created";
        }
        else
        {
            return "Failed to create referral";
        }
    }

    private string PersonUniqueId(string firstName, string lastName, DateTime dob)
    {
        return $"{firstName.ToUpper()}-{lastName.ToUpper()}-{dob:yyyyMMdd}";
    }

}
