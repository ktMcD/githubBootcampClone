import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { faHeart } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'like',
  templateUrl: './like.component.html',
  styleUrls: ['./like.component.css']
})
export class LikeComponent implements OnInit {
  faHeart = faHeart;

 @Input() isLiked: boolean;
 @Input() likesCount: number;
 @Output() click = new EventEmitter();


 onLike(){
   this.isLiked = !this.isLiked;
   this.likesCount += (this.isLiked) ? +1 : -1;
   this.click.emit(this.isLiked);
   this.click.emit(this.likesCount);
 }

  constructor() { }

  ngOnInit() {
  }

}
