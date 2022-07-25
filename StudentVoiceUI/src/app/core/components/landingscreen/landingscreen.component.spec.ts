import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LandingscreenComponent } from './landingscreen.component';

describe('LandingscreenComponent', () => {
  let component: LandingscreenComponent;
  let fixture: ComponentFixture<LandingscreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LandingscreenComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LandingscreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
