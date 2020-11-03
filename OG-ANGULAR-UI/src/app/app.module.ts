import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PersonaComponent } from './persona/persona.component';
import { PersonaAddEditComponent } from './persona/persona-add-edit/persona-add-edit.component';
import { PersonaShowComponent } from './persona/persona-show/persona-show.component';
import { PersonaService } from "./_services/persona.service";


@NgModule({
  declarations: [
    AppComponent,
    PersonaComponent,
    PersonaAddEditComponent,
    PersonaShowComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [PersonaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
