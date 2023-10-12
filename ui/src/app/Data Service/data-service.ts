import { Observable, map } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  private referralDetailsUrl = 'https://localhost:7177/Referrals/Update';

  constructor(private http: HttpClient) {}

  async postDetails(ReferralData: any): Promise<Observable<any>> {
    console.log(ReferralData)
    return this.http
      .post(this.referralDetailsUrl, ReferralData[0], { observe: 'response' })
      .pipe(
        map((res) => {
          return res.body;
        })
      );
  }
}
