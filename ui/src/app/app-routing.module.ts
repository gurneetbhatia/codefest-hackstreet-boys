import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UiReferralsComponent } from './referrals/referrals.component';

const routes: Routes = [
  {
    path: 'referral',
    component: UiReferralsComponent,
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
