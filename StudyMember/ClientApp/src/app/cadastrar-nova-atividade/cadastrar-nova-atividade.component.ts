import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-nova-atividade',
  templateUrl: './cadastrar-nova-atividade.component.html',
  styleUrls: ['./cadastrar-nova-atividade.component.css']
})
export class CadastrarNovaAtividadeComponent {
  // Form group for the activity registration form
  registerActivityForm: FormGroup;

  constructor(private fb: FormBuilder) {
    // Initialize the form with FormBuilder
    this.registerActivityForm = this.fb.group({
      nome: ['', Validators.required],
      dataPrazo: ['', Validators.required],
      tipoAtividade: ['', Validators.required],
      valor: ['', Validators.required],
      dataEntrega: [''],
      notaRecebida: ['']
    });
  }

  // Method to handle form submission
  onSubmit() {
    if (this.registerActivityForm.valid) {
      const formData = this.registerActivityForm.value;
      console.log('Form Submitted!', formData);
      // Aqui você pode adicionar a funcionalidade para processar os dados do formulário,
      // como enviá-los para um serviço backend ou atualizar o estado.
      // Por exemplo:
      // this.activityService.addNewActivity(formData).subscribe(response => {
      //   console.log('Activity added successfully', response);
      // });
    } else {
      console.log('Form is not valid');
    }
  }
}
