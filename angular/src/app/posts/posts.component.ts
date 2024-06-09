import { Component, OnInit } from '@angular/core';
import { PostService } from '../services/post.service';
import { trigger, state, style, transition, animate } from '@angular/animations';


@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css'],
  animations: [
    trigger('divState', [
      state('normal', style({
        backgroundColor: 'red',
        transform: 'translateX(0)'
      })),
      state('highlighted', style({
        backgroundColor: 'blue',
        transform: 'translateX(100px)'
      })),
      transition('normal => highlighted', animate(300)),
      transition('highlighted => normal', animate(800))
    ]),
    trigger('wildState', [
      state('normal', style({
        backgroundColor: 'red',
        transform: 'translateX(0) scale(1)'
      })),
      state('highlighted', style({
        backgroundColor: 'blue',
        transform: 'translateX(100px) scale(1)'
      })),
      state('shrunken', style({
        backgroundColor: 'green',
        transform: 'translateX(0) scale(0.5)',
        borderRadius: '50px'
      })),
      // transition('normal <=> highlighted', animate(300))
      transition('normal => highlighted', animate(300)),
      transition('highlighted => normal', animate(800)),
      transition('shrunken <=> *', [
        animate(1000, style({
          backgroundColor: 'orange'
        })),
        animate(500)
        ])
      ]),
      trigger('list', [
        state('in', style({
          opacity: 1,
          transform: 'translateX(0)'
        })),
        transition('void => *', [
          style({
            opacity: 0,
            transform: 'translateX(-100px)'
          }),
          animate(300)
        ]),
        transition('* => void', [
          animate(300, style({
            transform: 'translateX(100px)',
            opacity: 0,
          })),
        ]),
    ]),
  ]
})

export class PostsComponent implements OnInit {
state = 'normal';
wildState = 'normal';
posts: any;
isFetching = true;

  constructor(private service: PostService) {
   }

   ngOnInit() {
   this.service.getPosts()
    .subscribe(
      response => {
        this.posts = response;
        this.isFetching = false;
    }, 
      (error: Response) => {
        if (error.status === 404) {
          alert("This post has already been deleted.")
        } else {
          alert("An unexpected error has occurred");
        } 
    });
   }

   createPost(input: HTMLInputElement) {
     let postData = { title: input.value, id: "" };
     this.posts.splice(0, 0, postData)
     input.value = "";
     this.service.createPost(postData)
     .subscribe(
      response => {
        postData['id'] = response.id;
     }, 
      (error: Response) => {
        alert("An unexpected error has occurred");
    });
   }

   updatePost(post) {
    this.service.updatePost(post)
     .subscribe(
      response => {
        console.log(response);
     }, 
      error => {
        alert("An unexpected error has occurred");
    })
   }

   deletePost(post) {
    let index = this.posts.indexOf(post);
    this.posts.splice(index, 1);
    this.service.deletePost(post.id)
     .subscribe(
      response => {
        return;
     }, 
      (error: Response) => {
        if (error.status === 404)
          alert("This post has already been deleted");
        else {
          alert("An unexpected error has occurred");
          console.log(error);
        }
    })
   }

   onAnimate(){
     console.log(this.state, this.wildState);
     this.state == 'normal' ? this.state = 'highlighted' : this.state = 'normal';
     this.wildState == 'normal' ? this.wildState = 'highlighted' : this.wildState = 'normal';
   }

   onShrink() {
    this.wildState == 'shrunken' ? this.wildState = 'normal' : this.wildState = 'shrunken';
   }

}
