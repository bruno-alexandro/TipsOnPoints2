import { Component } from '@angular/core';
import { ThemeService } from '../../services/theme/theme.service';
import { Theme } from '../../services/theme/theme.model'; 
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-theme',
  templateUrl: './theme.component.html',
  styleUrls: ['./theme.component.scss'],
  standalone: true,
  imports: [FormsModule]
})
export class ThemeComponent {
  newTheme: Theme = {
    name: '',
    description: ''
    // Initialize other properties if needed
  };

  constructor(private themeService: ThemeService) {}

  createTheme() {
    this.themeService.createTheme(this.newTheme).subscribe(
      response => {
        console.log('Theme created successfully:', response);
        // Handle successful creation, e.g., reset form or show a message
      },
      error => {
        console.error('Error creating theme:', error);
        // Handle error
      }
    );
  }
}