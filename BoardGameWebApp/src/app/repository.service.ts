import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBoardGame } from './interfaces/board-game';

@Injectable({
  providedIn: 'root'
})
export class RepositoryService {


  constructor(private http: HttpClient) { }


  apiUri: string = 'https://localhost:7085/api/boardgame';


  getBoardGames() {
    return this.http.get(this.apiUri)
  }

  addBoardGames(game:IBoardGame)
  {
    alert("addBoardGames in repo");
    return this.http.post(`{this.apiUri}/add`,game);
  }


}

