import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { PaginaInicialComponent } from './pagina-inicial/pagina-inicial.component';
import { NotasComponent } from './notas/notas.component';
import { SemestreComponent } from './semestres/semestres.component';
import { CadastrarNovoSemestreComponent } from './cadastrar-novo-semestre/cadastrar-novo-semestre.component';
import { CadastrarNovaAtividadeComponent } from './cadastrar-nova-atividade/cadastrar-nova-atividade.component';
import { AtividadeComponent } from './atividade/atividade.component';
import { MenuDisciplinaComponent } from './menu-disciplina/menu-disciplina.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    SemestreComponent,
    NotasComponent,
    PaginaInicialComponent,
    CadastrarNovoSemestreComponent,
    CadastrarNovaAtividadeComponent,
    AtividadeComponent,
    MenuDisciplinaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: PaginaInicialComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'notas', component: NotasComponent},
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
      { path: 'semestres', component: SemestreComponent },
      { path: 'cadastrar-novo-semestre', component: CadastrarNovoSemestreComponent },
      { path: 'cadastrar-nova-atividade', component: CadastrarNovaAtividadeComponent },
      { path: 'atividade', component: AtividadeComponent },
      { path: 'menu-disciplina', component: MenuDisciplinaComponent }
    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
