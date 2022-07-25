import { Component, OnInit } from '@angular/core';
import { Survey } from 'src/app/shared/models/surveyModel';
import { SurveyService } from 'src/app/core/services/survey.service';
import { JwtHelperService } from '@auth0/angular-jwt';

interface Filter {
  value: string;
  viewValue: string;
}
interface Sort {
  value: string;
  viewValue: string;
}


@Component({
  selector: 'app-studentmainpage',
  templateUrl: './studentmainpage.component.html',
  styleUrls: ['./studentmainpage.component.scss']
})
export class StudentmainpageComponent implements OnInit {
  selectedFilter!: string;
  selectedSort!: string;
  surveys: Survey[] = [];



  filters: Filter[]=[
    {value: 'class', viewValue: 'Class'},
    {value: 'professors', viewValue: 'Professors'},
    {value: 'date', viewValue: 'Date'},
  ];

  sorts: Sort[]=[
    {value: 'likes', viewValue: 'Likes'},
    {value: 'rating', viewValue: 'Rating'},
  ];

  constructor(private surveyService: SurveyService, private jwtHelper: JwtHelperService){}

  ngOnInit() : void{
    this.surveyService
    .getSurveys()
    .subscribe((res: Survey[]) => (this.surveys = res));
  }

  isUserAuthenticated(){
    const token= localStorage.getItem("jwt");
    if(token && !this.jwtHelper.isTokenExpired){
      return true;
    }
    else{
      return false;
    }
  }


logOut(){
  localStorage.removeItem("jwt");
}



}
