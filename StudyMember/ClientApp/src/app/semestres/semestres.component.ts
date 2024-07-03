// src/app/semestre/semestre.component.ts
import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { Observable, async } from 'rxjs';
import { map } from 'rxjs/operators';

import { Router } from '@angular/router'; 

@Component({
  selector: 'app-semestre',
  templateUrl: './semestres.component.html',
  styleUrls: ['./semestres.component.css']
})
export class SemestreComponent implements OnInit {
   public semestres: Semestre[] = [];
  public isAuthenticated?: Observable<boolean>;
  public userName: string | undefined | null;
  public http: HttpClient | undefined;
  public baseUrl: string | undefined;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private authorizeService: AuthorizeService, private router: Router) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    this.isAuthenticated = this.authorizeService.isAuthenticated();
    this.authorizeService.getUser().pipe(
      map(u => u && u.name)
    ).subscribe(name => {
      this.userName = name;
    });

    this.http?.get<Semestre[]>(this.baseUrl + 'semestre?email=' + this.userName).subscribe(result => {
      this.semestres = result;
      console.log(result);
    }, error => console.error(error));
  }

  navegarParaCadastrarNovoSemestre(): void {
    this.router.navigate(['/cadastrar-novo-semestre']);
  }
}
interface Semestre {
  id: number;
  ano: number;
  semestreReferencia: number;
}
