import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListaDadosComponent } from './components/data-display/data-display.component'
import { ThemeComponent } from './components/theme/theme.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    ListaDadosComponent,
    ThemeComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'TipsOnPoints2';
}
