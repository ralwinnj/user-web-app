import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';

import * as m from '../models/user';

const headers = new HttpHeaders()
  .set("X-Requested-With", "XMLHttpRequest")
  .set("Accept", "application/json")
  .set("Content-Type", "application/json");
const requestOptions = { headers };
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl) {
    this.baseUrl = baseUrl;
  }

  getUsers() {
    return this.http.get(`${this.baseUrl}api/user`, requestOptions);
  }

  AddUser(user: m.IUser) {
    return this.http.post(`${this.baseUrl}api/user`, user, requestOptions);
  }

  updateUser(id, user: m.IUser) {
    return this.http.post(`${this.baseUrl}api/user/${id}`, user, requestOptions);
  }

  deleteUser(id) {
    return this.http.delete(`${this.baseUrl}api/user/${id}`, requestOptions);
  }

}
