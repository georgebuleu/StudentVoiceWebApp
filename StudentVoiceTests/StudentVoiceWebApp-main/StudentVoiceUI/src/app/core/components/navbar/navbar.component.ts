import {Component} from '@angular/core';
import {LogoutService} from "../../services/logout.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent  {
  loggedIn = this.logoutService.isUserAuthenticated();

  constructor
  (
    private logoutService: LogoutService,
    private router:Router
  ) {}

  logout(){
    this.logoutService.logout();
    this.router.navigate([''])

  }
}


