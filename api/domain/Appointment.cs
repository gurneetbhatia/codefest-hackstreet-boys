using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ServiceID { get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int StatusID { get; set; }

        public TimeSpan GetDuration()
        {
            return EndTime.Subtract(StartTime);
        }
    }
}