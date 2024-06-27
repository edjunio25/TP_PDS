import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-novo-semestre',
  templateUrl: './CadastrarNovoSemestre.component.html',
  styleUrls: ['./CadastrarNovoSemestre.component.css']
})
export class CadastrarNovoSemestreComponent {
  // Form group for the semester registration form
  registerSemesterForm: FormGroup;

  constructor(private fb: FormBuilder) {
    // Initialize the form with FormBuilder
    this.registerSemesterForm = this.fb.group({
      nomeDisciplina: ['', Validators.required],
      codigoDisciplina: [''],
      dataInicio: [''],
      dataTermino: ['']
    });
  }

  // Method to handle form submission
  onSubmit() {
    if (this.registerSemesterForm.valid) {
      const formData = this.registerSemesterForm.value;
      console.log('Form Submitted!', formData);
      // Here, you can add functionality to process the form data,
      // such as sending it to a backend service or updating the state.
      // For example:
      // this.semesterService.addNewSemester(formData).subscribe(response => {
      //   console.log('Semester added successfully', response);
      // });
    } else {
      console.log('Form is not valid');
    }
  }
}
