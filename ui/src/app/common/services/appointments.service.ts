import { Injectable } from '@angular/core';
import { IAppointment, Service, Status } from '../models/Appointment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentsService {

  private appointments: [IAppointment];

  constructor() {
    const mockAppointments: [IAppointment] = [
      {
        title: 'first appt',
        startTime: new Date('2024-01-01'),
        duration: 40,
        service: Service.someservice,
        patientId: '12345',
        createdByEId: '82639',
        notes: 'notes-key',
        location: '1234 your house',
        therapistEid: '292749',
        status: Status.somestatus
      }
    ]

    this.appointments = mockAppointments;
  }

  getAppointments(): [IAppointment] {
    return this.appointments;
  }
}
