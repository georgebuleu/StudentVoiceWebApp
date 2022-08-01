import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApprovequestionsComponent } from './approvequestions.component';

describe('ApprovequestionsComponent', () => {
  let component: ApprovequestionsComponent;
  let fixture: ComponentFixture<ApprovequestionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApprovequestionsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApprovequestionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
