import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PokemonViewComponent } from './pokemon-view/pokemon-view.component';
import { TrainerViewComponent } from './trainer-view/trainer-view.component';

@NgModule({
  declarations: [
    AppComponent,
    PokemonViewComponent,
    TrainerViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
