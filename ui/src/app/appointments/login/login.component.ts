import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { DataService } from 'src/app/common/services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form: FormGroup = new FormGroup({
    email: new FormControl('', Validators.required),
    userType: new FormControl('Patient')
  });

  constructor(private dataService: DataService,
              private router: Router) { }

  ngOnInit(): void {
  }

  login() {
    this.dataService.login(this.form.controls['email'].value, this.form.controls['userType'].value);
    // this.router.navigate(['/dashboard', { page: 'Appointments' }]);
    this.router.navigateByUrl('/dashboard/' + 'Appointments')
  }

}
