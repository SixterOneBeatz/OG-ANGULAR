import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Persona } from '../models/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  readonly APIUrl = 'http://localhost:58204/api/Persona';
  constructor(private http: HttpClient) { }

  getPersonas(): Observable<Persona[]> {
    return this.http.get<Persona[]>(this.APIUrl);
  }
  getPersonaById(id:number): Observable<Persona> {
    return this.http.get<Persona>(`${this.APIUrl}/${id}`);
  }
  addPersona(persona:Persona) {
    return this.http.post(this.APIUrl,persona);
  }
  updatePersona(persona:Persona) {
    return this.http.put(`${this.APIUrl}/${persona.id}`,persona);
  }
  deletePersona(persona:Persona) {
    return this.http.delete(`${this.APIUrl}/${persona.id}`);
  }
}
