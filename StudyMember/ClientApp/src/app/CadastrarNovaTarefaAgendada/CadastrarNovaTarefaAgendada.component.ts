import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'app-cadastrar-nova-tarefa-agendada',
    templateUrl: './CadastrarNovaTarefaAgendada.component.html',
    styleUrls: ['./CadastrarNovaTarefaAgendada.component.css']
})
export class CadastrarNovaTarefaAgendadaComponent {
  registerScheduledTaskForm: FormGroup;
  
  constructor(private fb : FormBuilder) {
    this.registerScheduledTaskForm = this.fb.group({
      nomeTarefa: ['', Validators.required],
      descricaoTarefa: [''],
      dataInicio: ['', Validators.required],
      dataTermino: ['', Validators.required],
      tipoTarefa: ['', Validators.required]
    });
  }
  
    onSubmit() {
      if (this.registerScheduledTaskForm.valid) {
        const formData = this.registerScheduledTaskForm.value;
        console.log('Formulário enviado!', formData);
      } else {
        console.log('Formulário inválido');
      }
    }
  }