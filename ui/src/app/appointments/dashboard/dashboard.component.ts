import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
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
              private apptsService: AppointmentsService,
              private router: Router,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.userType = this.userService.getUserType();
    this.appointments = this.apptsService.getAppointments();
    this.currentPage = this.route.snapshot.paramMap.get('page');
  }

  navLinkClicked(link: string): void {
    this.currentPage = link;
    console.log('here')
    console.log(this.currentPage)
    this.router.navigateByUrl('/dashboard/' + this.currentPage);
 }

 cancelAppt(apptIndex: number): void {
  console.log('Cancel appt ' + apptIndex);
 }

}
