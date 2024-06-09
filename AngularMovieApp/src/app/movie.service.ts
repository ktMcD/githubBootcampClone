import { Injectable } from '@angular/core';
import { IMovie } from 'src/interfaces/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  movies : IMovie[] = [
    { title: "Toy Story", releaseYear: 1995 },
    { title: "Forrest Gump", releaseYear: 1994 }
  ]

  constructor() { }

  getMovies(): IMovie[] {
    return this.movies
  }
}
