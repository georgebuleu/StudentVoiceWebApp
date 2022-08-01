import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SubmitquestionComponent } from './submitquestion.component';

describe('SubmitquestionComponent', () => {
  let component: SubmitquestionComponent;
  let fixture: ComponentFixture<SubmitquestionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SubmitquestionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SubmitquestionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
