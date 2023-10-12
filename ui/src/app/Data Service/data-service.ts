import { Observable, map } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  private referralDetailsUrl = 'Referrals/Update';

  constructor(private http: HttpClient) {}

  async postDetails(ReferralData: any): Promise<Observable<any>> {
    return this.http
      .post(this.referralDetailsUrl, ReferralData, { observe: 'response' })
      .pipe(
        map((res) => {
          return res.body;
        })
      );
  }
}
