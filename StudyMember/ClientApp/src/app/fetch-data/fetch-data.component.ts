import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { Observable, async } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit{
  public semestre: Semestre[] = [];
  public forecasts: WeatherForecast[] = [];
  public isAuthenticated?: Observable<boolean>;
  public userName: string | undefined | null;
  public http: HttpClient | undefined;
  public baseUrl: string | undefined;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private authorizeService: AuthorizeService) {
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
      this.semestre = result;
      console.log(result);
    }, error => console.error(error));
  }
}

interface Semestre {
  id: number;
  ano: number;
  semestrereferencia: number;
}
interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

