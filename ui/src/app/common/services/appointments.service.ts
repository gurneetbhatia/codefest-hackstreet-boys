import { Injectable } from '@angular/core';
import { IAppointment, Service, Status } from '../models/Appointment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentsService {

  private appointments: [IAppointment];

  constructor() {
    const mockAppointments = [
      {
        title: 'first appt',
        startTime: new Date('2024-01-01'),
        duration: '40',
        service: Service.someservice,
        patientId: '12345',
        createdById: '82639',
        notes: 'notes-key',
        location: '1234 your house',
        therapistId: '292749',
        status: Status.somestatus
      }
    ]
  }

  getAppointments(): [IAppointment] {
    return this.appointments;
  }
}
