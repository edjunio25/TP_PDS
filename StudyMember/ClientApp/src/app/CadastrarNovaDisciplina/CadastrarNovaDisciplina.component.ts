import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-nova-disciplina',
  templateUrl: './CadastrarNovaDisciplina.component.html',
  styleUrls: ['.CadastrarNovaDisciplina.component.css']
})
export class CadastrarNovaDisciplinaComponent {
  registerDisciplineForm: FormGroup;

  constructor(private fb : FormBuilder) {
    this.registerDisciplineForm = this.fb.group({
      nomeDisciplina: ['', Validators.required],
      codigoDisciplina: ['']
    });
  }

  onSubmit() {
    if (this.registerDisciplineForm.valid) {
      const formData = this.registerDisciplineForm.value;
    } else {
      console.log('O formulário não é válido');
    }
  }
}