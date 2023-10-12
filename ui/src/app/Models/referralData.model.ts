export class ReferralData {
  Id: number;
  GPName: string;
  FirstName: string;
  LastName: string;
  DOB: string;
  Address: string;
  Email: string;
  PatientExists: boolean;

  constructor(
    Id: number,
    GPName: string,
    FirstName: string,
    LastName: string,
    DOB: string,
    Address: string,
    Email: string,
    PatientExists: boolean
  ) {
    this.Id = Id;
    this.GPName = GPName;
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.DOB = DOB;
    this.Address = Address;
    this.Email = Email;
    this.PatientExists = PatientExists;
  }
}
