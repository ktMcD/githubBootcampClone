import { Component } from '@angular/core';
import { IMovie } from 'src/interfaces/movie';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent {

  movies: IMovie[] = [];
  
  constructor(private movieList: MovieService) { }
  ngOnInit(): void {
    this.movies = this.movieList.getMovies();
  }
}