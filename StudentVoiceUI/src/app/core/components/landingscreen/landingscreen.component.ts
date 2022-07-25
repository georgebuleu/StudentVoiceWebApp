import { Component, NgModule, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-landingscreen',
  templateUrl: './landingscreen.component.html',
  styleUrls: ['./landingscreen.component.scss']
})
export class LandingscreenComponent implements OnInit {
  invalidLogin?: boolean;
  url ="auth/login";

  constructor(private router: Router, private http: HttpClient) { }

  ngOnInit(): void {}

  login(form: NgForm) {

    const credentials = {
      'username': form.value.username,
      'password':form.value.password
    }

    this.http.post(`${environment.apiURL}/${this.url}`,credentials)
    .subscribe(res => {
      const token = (<any>res).token;
      localStorage.setItem("jwt",token);
      this.invalidLogin = false;
      this.router.navigate(["/studentmainpage"]);
    }, err =>{
      this.invalidLogin = false;
    });
  }
}
