import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonaAddEditComponent } from './persona-add-edit.component';

describe('PersonaAddEditComponent', () => {
  let component: PersonaAddEditComponent;
  let fixture: ComponentFixture<PersonaAddEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonaAddEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonaAddEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
