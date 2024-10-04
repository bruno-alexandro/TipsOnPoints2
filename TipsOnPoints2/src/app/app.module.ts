import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import { ListaDadosComponent } from './components/data-display/data-display.component';
import { ThemeComponent } from './components/theme/theme.component';
import { AppRoutingModule } from './app.routes';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    ListaDadosComponent,
    ThemeComponent
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
