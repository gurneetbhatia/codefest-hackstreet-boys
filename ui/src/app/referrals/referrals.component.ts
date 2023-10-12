import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DataService } from '../Data Service/data-service';
import { ReferralData } from '../Models/referralData.model';

@Component({
  selector: 'app-ui-referrals',
  templateUrl: './referrals.component.html',
  styleUrls: ['./referrals.component.scss'],
})
export class UiReferralsComponent {
  patientForm: FormGroup = new FormGroup({});
  request: any[] = [];
  constructor(private fb: FormBuilder, private dataService: DataService) {}

  ngOnInit() {
    this.patientForm = this.fb.group({
      patientName: ['', [Validators.required]],
      gpName: ['', [Validators.required]],
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
      dob: ['', [Validators.required]],
      address: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
    });
  }

  async submitForm() {
    if (this.patientForm.valid) {
      // Process and save the form data here
      console.log(this.patientForm.value);

      const referrals = <ReferralData>{
        FirstName: this.patientForm.value.firstName,
        LastName: this.patientForm.value.lastName,
        DOB: this.patientForm.value.dob,
        Address: this.patientForm.value.address,
        Email: this.patientForm.value.email,
        GPName: this.patientForm.value.gpName,
        PatientExists: false,
      };

      this.request.push(referrals);
      (await this.dataService.postDetails(this.request)).subscribe();
    }
  }
}
