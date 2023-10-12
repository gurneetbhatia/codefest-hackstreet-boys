import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
  }

  login(): void {
    this.dataService.login(this.form.controls['email'].value, this.form.controls['userType'].value);
  }

}
