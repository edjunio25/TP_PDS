import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; 

interface Disciplina {
  nome: string;
  provas: string[];
  atividades: string[];
  trabalhos: string[];
  outros: string[];
}

@Component({
  selector: 'app-notas',
  templateUrl: './notas.component.html',
  styleUrls: ['./notas.component.css']
})
export class NotasComponent implements OnInit {
  // Array para armazenar as disciplinas
  disciplinas: Disciplina[] = [];

  constructor(private router: Router) { }

  // Inicializando com uma disciplina de exemplo
  ngOnInit(): void {
    this.disciplinas = [
      {
        nome: 'Matemática',
        provas: ['Prova 1', 'Prova 2'],
        atividades: ['Atividade 1'],
        trabalhos: ['Trabalho 1'],
        outros: ['Outro 1']
      }
    ];
  }

  // Função para adicionar uma nova disciplina
  adicionarDisciplina(): void {
    const novaDisciplina: Disciplina = {
      nome: 'Nova Disciplina', 
      provas: [],
      atividades: [],
      trabalhos: [],
      outros: []
    };
    this.disciplinas.push(novaDisciplina);
  }

  navegarParaCadastrarNovaAtividade(): void {
    this.router.navigate(['/cadastrar-nova-atividade']);
  }
}
