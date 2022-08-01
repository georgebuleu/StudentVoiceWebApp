import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.scss']
})
export class StatisticsComponent implements OnInit {
  survey: string | undefined;
  title: string[] = ['Winter', 'Spring', 'Summer', 'Autumn'];
  constructor() { }

  ngOnInit(): void {
  }

}
