import { Component, OnInit } from '@angular/core';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/_services/persona.service';

@Component({
  selector: 'app-persona-show',
  templateUrl: './persona-show.component.html',
  styleUrls: ['./persona-show.component.css']
})
export class PersonaShowComponent implements OnInit {

  constructor(private service:PersonaService) { }
  ListPersonas:Persona[];


  ModalTitle:string;
  ActivateAddEditPersonaComp:boolean;
  isDeleteAction:boolean;
  persona:Persona;


  ngOnInit(): void {
    this.obtenerPersonas();
  }

  addClick(){
    this.ModalTitle = 'Agregar Persona';
    this.ActivateAddEditPersonaComp = true;
    this.isDeleteAction = false;
    this.persona = new Persona();
    this.persona.id = 0;
  }

  editClick(p:Persona){
    this.persona = p; 
    this.ModalTitle = 'Editar Persona';
    this.ActivateAddEditPersonaComp = true;
    this.isDeleteAction = false;
  }

  deleteClick(p:Persona){
    this.ModalTitle = '¿Eliminar Persona?';
    this.ActivateAddEditPersonaComp = true;
    this.isDeleteAction = true;
    this.persona = p; 
  }

  closeModal(){
    this.ActivateAddEditPersonaComp = false;
    this.obtenerPersonas();
  }

  obtenerPersonas(){
    this.service.getPersonas().subscribe(response => this.ListPersonas = response);
  }
  
}
