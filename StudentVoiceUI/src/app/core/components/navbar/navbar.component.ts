import { Component, OnInit } from '@angular/core';
import { faBars,faBell,faUser } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent  {
  loggedIn: boolean = true;

  constructor() {}

}
