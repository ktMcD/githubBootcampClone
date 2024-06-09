import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class StorageService {

  constructor(private http: HttpClient) {}

  private url = 'https://angular-demo-5121d.firebaseio.com//posts.json';

  createNewPost(postData: {title:string, content: string}) {
    return this.http
      .post(
        this.url, 
        postData)
  }

  fetchPosts() {
    return this.http
    .get(this.url)
    .pipe(
      map(responseData => {
        const posts = [];
        for(const key in responseData) {
          if(responseData.hasOwnProperty(key)) {
            posts.push({...responseData[key], id: key})
          }
        }
        return posts;
      })
    )
  }

  deletePosts() {
    return this.http
      .delete(
      this.url)
  }

}
