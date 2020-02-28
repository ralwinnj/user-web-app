import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiService } from '../services/api.service';
import * as m from '../models/user';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {

  private responseData;
  private userForm: FormGroup;
  public user: m.IUser;

  constructor(private fb: FormBuilder,
    private router: Router,
    private api: ApiService) { }

  ngOnInit() {
    this.userForm = this.fb.group({
      name: ['', [Validators.required]],
      surname: ['', [Validators.required]],
      dateOfBirth: [null, [Validators.required]]
    });
  }

  saveUser() {
    if (!this.userForm.invalid) {
      this.user = this.userForm.value;
      this.api.AddUser(this.user)
        .subscribe(
          (data) => {
            this.responseData = data;
            this.router.navigate(
              ['']);
          }
        )
        ;
    } else {
      alert('Please fill in all fields.');
    }

  }

}
