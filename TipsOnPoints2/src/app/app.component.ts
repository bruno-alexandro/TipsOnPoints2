import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListaDadosComponent } from './components/data-display/data-display.component'

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    ListaDadosComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'TipsOnPoints2';
}
