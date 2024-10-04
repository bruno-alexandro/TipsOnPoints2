import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Theme } from './theme.model'; 

@Injectable({
  providedIn: 'root'
})
export class ThemeService {
  private apiUrl = 'http://localhost:8080/Theme';

  constructor(private http: HttpClient) {}

  createTheme(theme: Theme): Observable<Theme> {
    return this.http.post<Theme>(`${this.apiUrl}`, theme);
  }
}