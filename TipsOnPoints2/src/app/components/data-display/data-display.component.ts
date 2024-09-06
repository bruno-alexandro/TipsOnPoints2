import { Component, OnInit } from '@angular/core';
// import { DadosService } from '../../services/data.service';
// import { Dado } from '../../services/data.service'; // Importe a interface

@Component({
  selector: 'app-data-display',
  templateUrl: './data-display.component.html',
  styleUrls: ['./data-display.component.scss'],
  standalone: true
})
export class ListaDadosComponent implements OnInit {
  // dados: Dado[] = [];

  // constructor(private dadosService: DadosService) { }

  ngOnInit(): void {
    // this.dadosService.getDados().subscribe((dado: Dado[]) => {
    //   this.dados = dado;
    // });
    console.log('oi')
  }
}

// export { DadosService };
