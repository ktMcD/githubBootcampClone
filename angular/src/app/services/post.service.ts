import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PostService {
  private url = 'http://jsonplaceholder.typicode.com/posts';

  constructor(private http: HttpClient) { }

  getPosts() {
    return  this.http.get(this.url);
  }

  createPost(post) {
    return this.http.post<Record<string,string>>(this.url, post);
  }

  updatePost(post) {
    return  this.http.patch(this.url + "/" + post.id, {isRead: true});
  }

  deletePost(id) {
    return this.http.delete(this.url + "/" + id);
  }
}
