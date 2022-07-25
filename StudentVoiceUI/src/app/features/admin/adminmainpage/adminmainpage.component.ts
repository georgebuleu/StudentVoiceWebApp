import { Component, OnInit } from '@angular/core';

interface Filter {
  value: string;
  viewValue: string;
}
interface Sort {
  value: string;
  viewValue: string;
}

interface Survey{
  name: string;
}

@Component({
  selector: 'app-adminmainpage',
  templateUrl: './adminmainpage.component.html',
  styleUrls: ['./adminmainpage.component.scss']
})
export class AdminmainpageComponent implements OnInit {
  selectedFilter!: string;
  selectedSort!: string;
  selectedSurvey!: string;

  filters: Filter[]=[
    {value: 'class', viewValue: 'Class'},
    {value: 'professors', viewValue: 'Professors'},
    {value: 'date', viewValue: 'Date'},
  ];

  sorts: Sort[]=[
    {value: 'likes', viewValue: 'Likes'},
    {value: 'rating', viewValue: 'Rating'},
  ];

  surveys: Survey[]=[
    {name: 'survey'},
    {name: 'survey'},
    {name: 'survey'},
    {name: 'survey'},
    {name: 'survey'},
  ];
  ngOnInit(): void {
  }

}
