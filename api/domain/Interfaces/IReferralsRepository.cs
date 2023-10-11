namespace Domain.Interfaces;

public interface IReferralsRepository
{
    List<Referral> Get(string firstName, string lastName, DateTime dob);
    int Update(Referral referral);
}
