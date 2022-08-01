import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnswertosurveysComponent } from './answertosurveys.component';

describe('AnswertosurveysComponent', () => {
  let component: AnswertosurveysComponent;
  let fixture: ComponentFixture<AnswertosurveysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnswertosurveysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AnswertosurveysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
