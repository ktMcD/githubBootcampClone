import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IBoardGame } from './interfaces/board-game';
import { RepositoryService } from './repository.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'BoardGameWebApp';


  constructor(private repositoryService: RepositoryService) { }
  boardGames: any;
  gameTitle: string = "";
  description: string = "";
  yearPublished: number = -1;
  playerCount: number= -1


  ngOnInit(): void {
    this.getGames();
  }

  addBoardGame(form: NgForm) {
    let newGame: IBoardGame = {
      id: -1,
      title: form.form.value.title,
      description: form.form.value.description,
      yearPublished: form.form.value.yearPublished,
      recommendedPlayerCount: form.form.value.playerCount
    };
    alert("title: " + newGame.title);
    alert("description: " + newGame.description);
    alert("yearPublished: " + newGame.yearPublished);
    alert("recommendedPlayerCount: " + newGame.recommendedPlayerCount);

    this.repositoryService.addBoardGames(newGame).subscribe(
      () => {
        this.getGames();
      }
    );
    alert("addBoardGame end of function");
  };


  getGames() {
    alert("GetGames");
    this.repositoryService.getBoardGames().subscribe(
      (response) => { this.boardGames = response; });
  }
}
