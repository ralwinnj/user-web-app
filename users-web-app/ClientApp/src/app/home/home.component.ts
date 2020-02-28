import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Router } from '@angular/router';
import { IUser } from '../models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  responseData;
  users: IUser[]
  constructor(private api: ApiService, private router: Router) {

  }

  ngOnInit() {
    this.api.getUsers()
      .subscribe(
        (data) => {
          this.responseData = data;
          console.log(this.responseData)
          if (this.responseData.result.length > 0) {
            this.users = this.responseData.result;
            console.log('data', this.responseData.result == [], this.responseData);
          } else {
            this.users = null;
          }

        }
      )
  }

  addUser() {
    this.router.navigate(['/add']);
  }

  getAge(dob) {
    const today = new Date();
    const birthDate = new Date(dob);
    let age = today.getFullYear() - birthDate.getFullYear();
    const month = today.getMonth() - birthDate.getMonth();
    if (month < 0 || (month === 0 && today.getDate() < birthDate.getDate())) {
      age--;
    }
    return age;
  }


}
