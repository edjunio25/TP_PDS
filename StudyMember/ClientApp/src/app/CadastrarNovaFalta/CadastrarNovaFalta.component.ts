import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-nova-falta',
  templateUrl: './CadastrarNovaFalta.component.html',
  styleUrls: ['.CadastrarNovaFalta.component.css']
})
export class CadastrarNovaFaltaComponent {
  registerAbsenceForm: FormGroup;

  constructor(private fb : FormBuilder) {
    this.registerAbsenceForm = this.fb.group({
      dataFalta: ['', Validators.required],
      justificativaFalta: [''],
      anexoJustificativaFalta: [''],
      faltaAbonada: ['']
    });
  }

  onsubmit() {
    if (this.registerAbsenceForm.valid) {
      const formData = this.registerAbsenceForm.value;
      console.log('Formulário enviado!', formData);
    } else {
      console.log('Formulário inválido');
    }
  }
}