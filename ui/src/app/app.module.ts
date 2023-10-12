import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UiReferralsComponent } from './referrals/referrals.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataService } from './Data Service/data-service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [AppComponent, UiReferralsComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [DataService],
  bootstrap: [AppComponent],
})
export class AppModule {}
