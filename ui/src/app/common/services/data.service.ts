import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  base = 'localhost:3000/'

  constructor(private http: HttpClient) { }

  login(email: string, userType: string): void {
    // this.http.get(this.base + 'Person/Login?personType=' + userType + '&email=' + email).subscribe((res) => {
    //   console.log(res);
    // })
  }
}
