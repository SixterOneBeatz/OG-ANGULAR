import { Component, Input, OnInit } from '@angular/core';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/_services/persona.service';


@Component({
  selector: 'app-persona-add-edit',
  templateUrl: './persona-add-edit.component.html',
  styleUrls: ['./persona-add-edit.component.css']
})
export class PersonaAddEditComponent implements OnInit {

  constructor(private service: PersonaService,) { }
  
  @Input() inPersona: Persona;
  @Input() eliminar: boolean = false;

  blockControls:boolean = false;

  persona: Persona;

  ngOnInit(): void {
    this.persona = this.inPersona;
  }
  addPersona(p: Persona) {
    this.service.addPersona(p).subscribe(response => {
      if(response == 1){
        this.disableModal();
        alert('Agregado con éxito');
      }
    });
  }
  updatePersona(p: Persona){
    this.service.updatePersona(p).subscribe(response => {
      if(response == 1){
        this.disableModal();
        alert('Actualizado con éxito');
      }
    });
  }
  deletePersona(p:Persona){
    this.service.deletePersona(p).subscribe(response => {
      if(response == 1){
        this.disableModal();
        alert('Eliminado con éxito');
      }
    });
  }
  disableModal(){
    this.blockControls = true;
    this.eliminar = true;
  }
}
