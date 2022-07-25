import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Survey } from 'src/app/shared/models/surveyModel';

@Injectable({
  providedIn: 'root'
})
export class SurveyService {
  private url = "Survey"
  constructor(private http: HttpClient) { }

  public getSurveys(): Observable<Survey[]>{
    /*let survey = new Survey();
    survey.id = 1;
    survey.className = "2";
    survey.name = "Surevey 1";
    survey.date ="11/02/2022";
    survey.likes = 6;
    survey.professor = "Mike";
    survey.status = "completed";
    survey.subject="SD"
    */

    return this.http.get<Survey[]>(`${environment.apiURL}/${this.url}`);
}
}
