import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../../../environments/environment";
import {AuthModel} from "../../shared/models/authModel";
import {Observable} from "rxjs";
import {FormGroup} from "@angular/forms";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  url ="auth/login";

  constructor(private http: HttpClient) {}

  loginUser(credentials:AuthModel): Observable<any>{
   return  this.http.post<AuthModel>(`${environment.apiURL}/${this.url}`,credentials);
  }


}
