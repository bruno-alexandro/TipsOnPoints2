import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ListaDadosComponent } from './components/data-display/data-display.component';

@NgModule({
  declarations: [
    AppComponent,
    ListaDadosComponent
    
  ],
  imports: [
    BrowserModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
