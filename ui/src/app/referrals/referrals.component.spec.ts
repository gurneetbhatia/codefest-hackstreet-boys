import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UiReferralsComponent } from './referrals.component';

describe('UiReferralsComponent', () => {
  let component: UiReferralsComponent;
  let fixture: ComponentFixture<UiReferralsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UiReferralsComponent],
    });
    fixture = TestBed.createComponent(UiReferralsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
