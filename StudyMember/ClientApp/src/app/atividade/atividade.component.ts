import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-atividade',
  templateUrl: './atividade.component.html',
  styleUrls: ['./atividade.component.css']
})
export class AtividadeComponent implements OnInit {
  atividade: any; // armazenar dados da atividade
  notaRecebida: number | null= null; // armazenar a nota recebida

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    // TODO implementar com banco de dados
    this.atividade = {
      nome: 'Atividade de Angular',
      dataPrazo: '2024-07-10',
      tipoAtividade: 'atividade',
      valor: 100,
      dataEntrega: null, 
      notaRecebida: null 
    };
  }

  // entrega da atividade
  marcarEntrega(): void {
    this.atividade.dataEntrega = new Date().toLocaleDateString();
    // TODO integrar com BD
  }

  // inserir a nota recebida
  inserirNota(): void {
    if (this.notaRecebida !== undefined) {
      this.atividade.notaRecebida = this.notaRecebida;
      // TODO integrar com BD
    }
  }

  //excluir a atividade
  excluirAtividade(): void {
    // TODO integrar com BD
    console.log('Atividade excluída!');
    this.router.navigate(['/lista-atividades']); 
  }
}
