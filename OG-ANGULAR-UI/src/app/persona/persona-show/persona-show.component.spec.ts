import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonaShowComponent } from './persona-show.component';

describe('PersonaShowComponent', () => {
  let component: PersonaShowComponent;
  let fixture: ComponentFixture<PersonaShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonaShowComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonaShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
