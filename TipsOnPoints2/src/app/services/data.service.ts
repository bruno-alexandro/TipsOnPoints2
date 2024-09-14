import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { of } from 'rxjs';
import { MOCK_DADOS } from './mock-data';


export interface Dado {
  dicas: string[];
  resposta: string;
  escolha_do_subtema: string;
}

@Injectable({
  providedIn: 'root'
})
export class DadosService {
  private apiUrl = 'http://localhost:8080/Cards/GetNewCard'; // Substitua pela URL da sua API

  constructor(private http: HttpClient) { }

  getDados(): Observable<Dado> {
    //return this.http.get<Dado>(this.apiUrl);
    return of(MOCK_DADOS);
  }
}
