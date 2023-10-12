using Azure.Core;
using Domain;
using Domain.Interfaces;

namespace Infrastructure;

public class PersonRepository : IPersonRepository
{
    private readonly HackstreetDbContext _context;

    public PersonRepository(HackstreetDbContext context)
    {
        _context = context;
    }

    public Patient GetPatient(string email)
    {
        return _context.Patients.SingleOrDefault(x => x.Email == email);

    }

    public Employee GetEmployee(string email)
    {
        return _context.Employees.SingleOrDefault(x => x.Email == email);
    }

    //public int UpdatePatientDetails(Patient patient)
    //{
    //    //var referral = referralJsonObject.ToObject<Referral>();

    //    //var patientOldDetails = _context.Patients.SingleOrDefault(x => x.Id == patient);

    //    //if (patient != null)
    //    //{
    //    //    referral.PatientExists = true;
    //    //}
    //    //else
    //    //{
    //    //    referral.PatientExists = false;

    //    //    _context.Patients.Add(new Patient
    //    //    {
    //    //        FirstName = referral.FirstName,
    //    //        LastName = referral.LastName,
    //    //        Address = referral.Address,
    //    //        Email = referral.Email,
    //    //        DOB = referral.DOB
    //    //    });
    //    //}

    //    //_context.Referrals.Add(referral);

    //    //return _context.SaveChanges();
    //}

    private string PersonUniqueId(string firstName, string lastName, DateTime dob)
    {
        return $"{firstName.ToUpper()}-{lastName.ToUpper()}-{dob:yyyyMMdd}";
    }

}
