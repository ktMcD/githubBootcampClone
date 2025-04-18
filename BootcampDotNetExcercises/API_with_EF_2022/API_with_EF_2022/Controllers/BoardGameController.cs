﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_with_EF_2022.DAL;
using API_with_EF_2022.Models;
using System.Net;

namespace API_with_EF_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGameController : ControllerBase
    {
        BoardGameRepository repo = new BoardGameRepository();

        [HttpPost("add")]
        public BoardGame AddBoardGame(string title, string description, int year, int count)
        {
            BoardGame newBoardGame = new BoardGame
            {
                Title = title,
                Description = description,
                YearPublished = year,
                RecommendedPlayerCount = count
            };
            return repo.AddBoardGame(newBoardGame);
        }

        [HttpGet()]
        public List<BoardGame> GetAll()
        {
            return repo.GetAllGames();
        }

        [HttpGet("{id}")]
        public BoardGame GetById(int id)
        {
            return repo.FindById(id);
        }

        [HttpPost("delete/{id}")]
        public HttpResponseMessage DeleteById(int id)
        {
            try
            {
                if (repo.DeleteById(id) == true)
                {
                    return new HttpResponseMessage(HttpStatusCode.NoContent);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
            }
        }
    }
}
