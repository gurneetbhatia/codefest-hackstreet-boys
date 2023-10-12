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

    public List<Appointment> Get(string patientId, string therapistId)
    {
        if (!string.IsNullOrEmpty(patientId) && !string.IsNullOrEmpty(therapistId))
            return _context.Appointments.Where(x => x.PatientID == patientId && x.TherapistId == therapistId).ToList();

        if (!string.IsNullOrEmpty(patientId))
            return _context.Appointments.Where(x => x.PatientID == patientId).ToList();

        if (!string.IsNullOrEmpty(therapistId))
            return _context.Appointments.Where(x => x.TherapistId == therapistId).ToList();

        return _context.Appointments.ToList();
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
