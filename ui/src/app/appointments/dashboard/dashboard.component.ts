import { Component, OnInit } from '@angular/core';
import { IUser } from 'src/app/common/models/User';
import { UserService } from 'src/app/common/services/user.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  userType: string;

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userType = this.userService.getUserType();
  }

}
