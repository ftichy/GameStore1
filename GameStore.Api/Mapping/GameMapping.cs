using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping
{
    public static class GameMapping
    {
        public static Game ToEntity(this CreateGameDto gameDto)
        {
            return new Game
            {
                Name = gameDto.Name,
                GenreId = gameDto.GenreId,
                Price = gameDto.Price,
                ReleaseDate = gameDto.ReleaseDate
            };
        }

        public static Game ToEntity(this UpdateGameDto gameDto, int id)
        {
            return new Game
            {
                Id = id,
                Name = gameDto.Name,
                GenreId = gameDto.GenreId,
                Price = gameDto.Price,
                ReleaseDate = gameDto.ReleaseDate
            };
        }

        public static GameSummaryDto ToGameSummaryDto(this Game game)
        {
            return new GameSummaryDto(game.Id, game.Name, game.Genre!.Name, game.Price, game.ReleaseDate);
        }

        public static GameDetailsDto ToGameDetailsDto(this Game game)
        {
            return new GameDetailsDto(game.Id, game.Name, game.GenreId, game.Price, game.ReleaseDate);
        }
    }
}