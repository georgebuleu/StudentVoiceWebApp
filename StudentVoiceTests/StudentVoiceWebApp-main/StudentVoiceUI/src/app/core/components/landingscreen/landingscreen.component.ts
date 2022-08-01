import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import {HttpClient} from '@angular/common/http';
import {AuthService} from "../../services/auth.service";
import {FormControl, FormGroup} from "@angular/forms";

@Component({
  selector: 'app-landingscreen',
  templateUrl: './landingscreen.component.html',
  styleUrls: ['./landingscreen.component.scss']
})
export class LandingscreenComponent implements OnInit {

  invalidLogin?: boolean;


  loginFormGroup: FormGroup = new FormGroup({
    email: new FormControl(''),
    password:new FormControl('')
  })

  constructor(
    private router: Router,
    private http: HttpClient,
    private authService:AuthService
  ) { }

  ngOnInit(): void {

  }
  onSubmitForm(){
  this.authService.loginUser({email:this.loginFormGroup.get('email')?.value, password:this.loginFormGroup.get('password')?.value})
    .subscribe({
       next: res => {
      const token = (<any>res).token;
      localStorage.setItem("jwt",token);
      this.invalidLogin=false;
      this.router.navigate(["/studentmainpage"]).then(r => console.log("Route student",r))
    },
      error: err => {
         this.invalidLogin=true;
         console.log(err);
      }
      }
    )
}


}
