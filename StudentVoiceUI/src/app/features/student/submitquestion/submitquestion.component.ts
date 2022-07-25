import { Component, OnInit } from '@angular/core';

interface Filter {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-submitquestion',
  templateUrl: './submitquestion.component.html',
  styleUrls: ['./submitquestion.component.scss']
})
export class SubmitquestionComponent implements OnInit {
  selectedFilter!: string;

  filters: Filter[]=[
    {value: 'class', viewValue: 'Class'},
    {value: 'professors', viewValue: 'Professors'},
    {value: 'date', viewValue: 'Date'},
  ];

  ngOnInit(): void {
  }

}
