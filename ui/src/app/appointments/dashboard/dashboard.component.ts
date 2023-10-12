import { Component, OnInit } from '@angular/core';
import { IAppointment } from 'src/app/common/models/Appointment';
import { IUser } from 'src/app/common/models/User';
import { AppointmentsService } from 'src/app/common/services/appointments.service';
import { UserService } from 'src/app/common/services/user.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  userType: string;
  appointments: [IAppointment];
  patients: [IUser];
  currentPage = 'Patients';

  constructor(private userService: UserService,
              private apptsService: AppointmentsService) { }

  ngOnInit(): void {
    this.userType = this.userService.getUserType();
    this.appointments = this.apptsService.getAppointments();
  }

  navLinkClicked(link: string): void {
    this.currentPage = link;
  }

}
