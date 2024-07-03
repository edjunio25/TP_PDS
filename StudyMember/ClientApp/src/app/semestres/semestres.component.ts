// src/app/semestre/semestre.component.ts
import { Component, OnInit } from '@angular/core';

import { Router } from '@angular/router'; 

@Component({
  selector: 'app-semestre',
  templateUrl: './semestres.component.html',
  styleUrls: ['./semestres.component.css']
})
export class SemestreComponent implements OnInit {
  semestres: Semestre[] = [];
  
  constructor(private router: Router) { }
  
  ngOnInit(): void {
    //this.loadSemestres();
  }
  /*
  loadSemestres(): void {
    this.SemestreController.getSemestres().subscribe(
      (data: Semestre[]) => {
        this.semestres = data;
      },
        (error: any) => {
        console.error('Erro ao buscar semestres:', error);
      }
    );
  }

  gerenciarSemestre(semestre: Semestre): void {
    console.log('Gerenciar semestre:', semestre);
    // linkar para a página de gerenciar semestre
  }

 */

  navegarParaCadastrarNovoSemestre(): void {
    this.router.navigate(['/cadastrar-novo-semestre']);
  }
}
interface Semestre {
  id: number;
  ano: number;
  semestrereferencia: number;
}
