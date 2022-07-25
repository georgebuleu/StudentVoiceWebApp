import { Component, OnInit } from '@angular/core';

interface Professor {
  value: string;
}

@Component({
  selector: 'app-createsurvey',
  templateUrl: './createsurvey.component.html',
  styleUrls: ['./createsurvey.component.scss']
})
export class CreatesurveyComponent implements OnInit {
  selectedProfessor!: string;
  constructor() { }

  professors: Professor[]=[
    {value: 'class'},
    {value: 'professors'},
    {value: 'date'},
  ];

  ngOnInit(): void {
  }

}
