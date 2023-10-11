export interface IUser {
    uid: string;
    firstName: string;
    lastName: string;
    dob: Date;
    address: string;
    email: string;
    userType: 'Patient' | 'Therapist' | 'Admin';
}