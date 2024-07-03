import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu-disciplina',
  templateUrl: './menu-disciplina.component.html',
  styleUrls: ['./menu-disciplina.component.css']
})
export class MenuDisciplinaComponent implements OnInit {
  nomeDisciplina: string = 'Nome da Disciplina';
  status: string = 'Cursando'; // Exemplo de status
  faltas: number | undefined = 6;
  notaRecebida: number | undefined = 17.5; // Exemplo de nota recebida

  proximasAtividades: any[] = [
    { nome: 'Atividade 1', dataPrazo: '2024-07-10' },
    { nome: 'Atividade 2', dataPrazo: '2024-07-15' },
    // Adicione mais atividades conforme necessário
  ];

  atividadesConcluidas: any[] = [
    { nome: 'Projeto Final', notaRecebida: 9.0 },
    { nome: 'Trabalho Prático', notaRecebida: 8.5 },
    // Adicione mais atividades concluídas conforme necessário
  ];

  constructor() { }

  ngOnInit(): void {
    // Aqui você poderia obter os dados da disciplina, status, notas e atividades de um serviço ou parâmetros da rota
  }
}
