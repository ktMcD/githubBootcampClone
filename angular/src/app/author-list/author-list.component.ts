import { Component, OnInit } from '@angular/core';
import { AuthorsService } from '../services/authors.service';

@Component({
  selector: 'app-author-list',
  templateUrl: './author-list.component.html',
  styleUrls: ['./author-list.component.css']
})
export class AuthorListComponent implements OnInit {
  authors: string[];

  constructor(service: AuthorsService) { 
    this.authors = service.getAuthors();
  }
        
  ngOnInit() {
  }

}
