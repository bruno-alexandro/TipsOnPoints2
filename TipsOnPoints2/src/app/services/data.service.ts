import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Dado {
  // Defina aqui a estrutura dos seus dados
  id: number;
  nome: string;
  // ... outras propriedades
}

@Injectable({
  providedIn: 'root'
})
export class DadosService {
  private apiUrl = 'https://sua-api.com/dados'; // Substitua pela URL da sua API

  constructor(private http: HttpClient) { }

  getDados(): Observable<Dado[]> {
    return this.http.get<Dado[]>(this.apiUrl);
  }
}