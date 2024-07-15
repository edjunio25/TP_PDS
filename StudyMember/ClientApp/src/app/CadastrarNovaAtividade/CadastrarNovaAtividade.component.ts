import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-nova-atividade',
  templateUrl: './CadastrarNovaAtividade.component.html',
  styleUrls: ['./CadastrarNovaAtividade.component.css']
})
export class CadastrarNovaAtividadeComponent {
  registerExerciseForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.registerExerciseForm = this.fb.group({
      nomeAtividade: ['', Validators.required],
      dataPrazoAtividade: ['', Validators.required],
      tipoAtividade: ['', Validators.required],
      valorAtividade: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.registerExerciseForm.valid) {
      const formData = this.registerExerciseForm.value;
      console.log('Formulário enviado!', formData);
    } else {
      console.log('Formulário inválido');
    }
  }
}