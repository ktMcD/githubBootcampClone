import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { StorageService } from '../services/storage.service';

@Component({
  selector: 'storage',
  templateUrl: './storage.component.html',
  styleUrls: ['./storage.component.css']
})

export class StorageComponent implements OnInit {
  loadedPosts = [];
  isFetching = false;
  error = null;

  constructor(private http: HttpClient, private storageService: StorageService) { }

  ngOnInit() {
    this.onFetchPosts();
  }

  onCreatePost(postData: {title:string, content: string}) {
    this.loadedPosts.push(postData);
    this.storageService.createNewPost(postData)
    .subscribe(() => {
      return;
    });;
  }

  onFetchPosts() {
    this.isFetching = true;
    this.storageService.fetchPosts()
    .subscribe(
      posts => {
        this.isFetching = false;
        this.loadedPosts = posts;
      }, 
      error => {
        this.isFetching = false;
        if (error.status === 404 || 401) {
        this.error = "Unable to fetch posts";
      }
      }
    );
  }

  onHandleError() {
    this.error = null;
  }

  onClearPosts() {
    this.loadedPosts = [];
    this.storageService.deletePosts()
    .subscribe(() => {
      return;
    });
  }
}
