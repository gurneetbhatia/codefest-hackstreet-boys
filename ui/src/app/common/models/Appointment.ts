export interface IAppointment {
    title: string;
    startTime: Date;
    duration: number;
    service: Service;
    patientId: string;
    createdByEId: string;
    notes: string;
    location: string;
    therapistEid: string;
    status: Status;
}

export enum Service {
    someservice,
    someotherservice
}

export enum Status {
    somestatus,
    someotherstatus
}