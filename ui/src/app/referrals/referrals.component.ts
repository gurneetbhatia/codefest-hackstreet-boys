import { Component, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';

@Component({
  selector: 'app-ui-referrals',
  templateUrl: './referrals.component.html',
  styleUrls: ['./referrals.component.scss'],
})
export class UiReferralsComponent {
  patientForm: FormGroup; // Define the form

  constructor(private fb: FormBuilder) {
    this.patientForm = this.fb.group({
      patientName: ['', Validators.required],
      referredBy: ['', Validators.required],
      dob: ['', Validators.required],
    });
  }

  submitForm() {
    if (this.patientForm.valid) {
      // Process and save the form data here
      console.log(this.patientForm.value);
    }
  }
}
