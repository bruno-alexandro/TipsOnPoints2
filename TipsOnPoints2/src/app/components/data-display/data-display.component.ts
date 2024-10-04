import { Component, OnInit } from '@angular/core';
import { DadosService, Dado } from '../../services/card/data.service';

@Component({
  selector: 'app-data-display',
  templateUrl: './data-display.component.html',
  styleUrls: ['./data-display.component.scss'],
  standalone: true,
  imports: []
})
export class ListaDadosComponent implements OnInit {
  dados: Dado | undefined;

  constructor(private dadosService: DadosService) { }

  getNovaCarta(): void {
    this.dadosService.getDados().subscribe((data: any) => {
      this.dados = data;
      console.log(this.dados); // debug
    });
  }

  ngOnInit(): void {

  }
}
