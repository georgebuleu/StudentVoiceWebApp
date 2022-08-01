import {ComponentFixture, TestBed} from '@angular/core/testing';

import {ForgotyourpasswordComponent} from './forgotyourpassword.component';

describe('ForgotyourpasswordComponent', () => {
  let component: ForgotyourpasswordComponent;
  let fixture: ComponentFixture<ForgotyourpasswordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ForgotyourpasswordComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ForgotyourpasswordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
