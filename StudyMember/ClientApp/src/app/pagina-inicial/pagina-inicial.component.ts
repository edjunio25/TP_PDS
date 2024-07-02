// pagina-inicial.component.ts
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pagina-inicial',
  templateUrl: './pagina-inicial.component.html',
  styleUrls: ['./pagina-inicial.component.css']
})
export class PaginaInicialComponent implements OnInit {
  userName: string = "Usuário"; // Nome do usuário, pode ser alterado dinamicamente
  atividades = [
    { name: 'Atividade 1', date: '2024-06-30' },
    { name: 'Atividade 2', date: '2024-07-15' },
    { name: 'Atividade 3', date: '2024-07-20' }
  ];
  eventos = [
    { name: 'Evento 1', date: '2024-06-25' },
    { name: 'Evento 2', date: '2024-07-05' }
  ];
  disciplinas = [
    { name: 'Disciplina 1', status: 'Ativa' },
    { name: 'Disciplina 2', status: 'Completa' },
    { name: 'Disciplina 3', status: 'Pendente' }
  ];

  constructor() { }

  ngOnInit(): void {
    // Inicialização de componentes e carregamento de dados podem ocorrer aqui
  }
}

