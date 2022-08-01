import {Injectable} from '@angular/core';
import {environment} from 'src/environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Survey} from 'src/app/shared/models/surveyModel';

@Injectable({
  providedIn: 'root'
})
export class SurveyService {
  private url = "Survey"
  constructor(private http: HttpClient) { }

  public getSurveys(): Observable<Survey[]>{


    return this.http.get<Survey[]>(`${environment.apiURL}/${this.url}`);
}
}
