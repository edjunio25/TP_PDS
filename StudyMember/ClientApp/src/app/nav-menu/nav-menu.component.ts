import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  ngOnInit(): void {
    this.disciplinas = [
      { id: 1, name: 'Matemática' },
      { id: 2, name: 'História' },
      { id: 3, name: 'Biologia' },
      { id: 4, name: 'Química' },
      { id: 5, name: 'Física' }
    ];

    this.semestres = [
      { id: 1, name: '2020/1' },
      { id: 2, name: '2020/2' },
      { id: 3, name: '2023/1' },
      { id: 4, name: '2023/2' },
      { id: 5, name: '2024/1' }
    ];

  }
  public semestres: Semestre[] = [];
  public disciplinas: Disciplina[] = [];
  isExpanded = false;


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
interface Semestre {
  id: number;
  name: string;
  //ano: number;
  //semestrereferencia: number;
}
interface Disciplina {
  id: number;
  name: string;
}
