import { Injectable } from '@angular/core';
import { IUser } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private user: IUser;

  constructor() {
    const mockPatientUser: IUser = {
      uid: '12345',
      firstName: 'John The Patient',
      lastName: 'Doe',
      dob: new Date('05-06-2000'),
      address: '1234 some street',
      email: 'johndoe@gmail.com',
      userType: 'Patient'
    }
    const mockTherapistUser: IUser = {
      uid: '123465',
      firstName: 'John The Therapist',
      lastName: 'Doe',
      dob: new Date('05-06-2000'),
      address: '1234 some street',
      email: 'johntherapistdoe@gmail.com',
      userType: 'Patient'
    }
    const mockAdminUser: IUser = {
      uid: '1232145',
      firstName: 'John The Admin',
      lastName: 'Doe',
      dob: new Date('05-06-2000'),
      address: '1234 some street',
      email: 'johntheadmindoe@gmail.com',
      userType: 'Patient'
    }

    this.user = mockTherapistUser;
  }

  getUserType(): string {
    return this.user.userType;
  }


}
