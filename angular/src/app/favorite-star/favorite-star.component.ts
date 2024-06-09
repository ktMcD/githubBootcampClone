import { Component, OnInit } from '@angular/core';
import { faSquare } from '@fortawesome/free-solid-svg-icons';
import { faCheck } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-favorite-star',
  templateUrl: './favorite-star.component.html',
  styleUrls: ['./favorite-star.component.css']
})
export class FavoriteStarComponent implements OnInit {
  icon = faSquare;

  onLike(){
    this.icon = this.icon === faSquare ? faCheck : faSquare;
  }

  constructor() { }

  ngOnInit() {
  }

}
