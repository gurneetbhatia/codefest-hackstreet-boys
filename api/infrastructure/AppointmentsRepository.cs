using Domain;
using Domain.Interfaces;

namespace Infrastructure;

public class AppointmentsRepository : IAppointmentsRepository
{
    private readonly HackstreetDbContext _context;

    public AppointmentsRepository(HackstreetDbContext context)
    {
        _context = context;
    }

    public List<Appointment> Get(int? patientId, int? therapistId)
    {
        if (patientId.HasValue && therapistId.HasValue)
            return _context.Appointments.Where(x => x.PatientID == patientId.Value && x.TherapistId == therapistId.Value).ToList();

        if (patientId.HasValue)
            return _context.Appointments.Where(x => x.PatientID == patientId.Value).ToList();

        if (therapistId.HasValue)
            return _context.Appointments.Where(x => x.TherapistId == therapistId.Value).ToList();

        return new List<Appointment>();
    }

    public int Update(Appointment appt)
    {
        //var appointmentt = apptJsonObject.ToObject<Appointment>();

        if (appt == null) return 0;

        // update
        if (_context.Appointments.Any(x => x.Id == appt.Id))
            _context.Appointments.Update(appt);

        // create
        _context.Appointments.Add(appt);

        return _context.SaveChanges();
    }

}
