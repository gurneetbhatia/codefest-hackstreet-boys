using Domain;
using Domain.Interfaces;
using Newtonsoft.Json.Linq;

namespace Infrastructure;

public class AppointmentsRepository : IAppointmentsRepository
{
    private readonly HackstreetDbContext _context;

    public AppointmentsRepository(HackstreetDbContext context)
    {
        _context = context;
    }

    public List<Appointment> Get(int apptId)
    {
        return _context.Appointments.Where(x => x.Id == apptId).ToList();
    }

    public int Update(int apptId, JObject apptJsonObject)
    {
        var appt = apptJsonObject.ToObject<Appointment>();

        if (appt == null) return 0;

        // update
        if (_context.Appointments.Any(x => x.Id == apptId))
            _context.Appointments.Update(appt);

        // create
        _context.Appointments.Add(appt);

        return _context.SaveChanges();
    }

}
