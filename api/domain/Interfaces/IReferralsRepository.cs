using Newtonsoft.Json.Linq;

namespace Domain.Interfaces;

public interface IReferralsRepository
{
    List<Referral> Get(int referralId);
    int Update(int referralId, JObject jsonObject);
}
