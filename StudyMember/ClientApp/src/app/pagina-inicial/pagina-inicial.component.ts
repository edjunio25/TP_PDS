// pagina-inicial.component.ts
import { Component, OnInit } from '@angular/core';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
@Component({
  selector: 'app-pagina-inicial',
  templateUrl: './pagina-inicial.component.html',
  styleUrls: ['./pagina-inicial.component.css']
})
export class PaginaInicialComponent implements OnInit {
  public userName?: string | null;
  public isAuthenticated?: boolean;

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

  constructor(private authorizeService: AuthorizeService) {
    this.authorizeService.isAuthenticated().subscribe(result => {
      this.isAuthenticated = result;
      console.log(result);
    }, error => console.error(error));

    this.authorizeService.getUser().pipe(
      map(u => u && u.name)
    ).subscribe(name => {
      this.userName = name;
    });
  }

  ngOnInit(): void {
    
  }
}

