import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { map } from 'rxjs';
import { AuthorizeService } from '../../api-authorization/authorize.service';

@Component({
  selector: 'app-cadastrar-novo-semestre',
  templateUrl: './cadastrar-novo-semestre.component.html',
  styleUrls: ['./cadastrar-novo-semestre.component.css']
})
export class CadastrarNovoSemestreComponent {
  // Form group for the semester registration form
  registerSemesterForm: FormGroup;
  public http: HttpClient | undefined;
  public baseUrl: string | undefined;
  public userName: string | undefined | null;
  constructor(private fb: FormBuilder, @Inject('BASE_URL') baseUrl: string, http: HttpClient, private authorizeService: AuthorizeService) {
    this.http = http;
    this.baseUrl = baseUrl;

    this.registerSemesterForm = this.fb.group({
      nomeDisciplina: ['', Validators.required],
      codigoDisciplina: [''],
      dataInicio: [''],
      dataTermino: ['']
    });
  }
  ngOnInit() {
   
    this.authorizeService.getUser().pipe(
      map(u => u && u.name)
    ).subscribe(name => {
      this.userName = name;
    });

  }
  // Method to handle form submission
  onSubmit() {
    if (this.registerSemesterForm.valid) {
      const formData = this.registerSemesterForm.value;
      console.log('Form Submitted!', formData);
      this?.addNewSemester(formData)?.subscribe((response: any) => {
        console.log('Semester added successfully', response);
        // Optionally, refresh the list of semestres or perform other actions
      }, (error: any) => console.error(error));
    } else {
      console.log('Form is not valid');
    }
  }

  addNewSemester(semestre: Semestre) {
    return this.http?.post<Semestre>(this.baseUrl + 'semestre?email=' + this.userName, semestre);
  }

}

interface Semestre {
  id: number;
  ano: number;
  semestreReferencia: number;
}
