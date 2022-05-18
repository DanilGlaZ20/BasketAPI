using System.Collections.Generic;
using BasketAPI.Data;
using BasketAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasketAPI.Controllers
{
    [ApiController]
    public class PlayerApiController : ControllerBase
    {
        private readonly IPlayerContext _context;

        public PlayerApiController(IPlayerContext context)
        {
            _context = context;
        }

        [HttpGet("api/player")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Player>))]
        [ProducesResponseType(404)]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllPlayer());
        }

        [HttpGet("api/player/{id}")]
        [ProducesResponseType(200, Type = typeof(Player))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var player = _context.GetPlayerById(id);
            return player == default ? NotFound(player) : Ok(player);
        }

        [HttpGet("api/player/number/{number}")]
        [ProducesResponseType(200, Type = typeof(Player))]
        [ProducesResponseType(404)]
        public IActionResult GetByNumber(int number)
        {
            var  player = _context.GetPlayerByNumber(number);
            return player == default ? NotFound(number) : Ok(number);
        }

        [HttpGet("api/player/remove/{id}")]
        [ProducesResponseType(200, Type = typeof(Player))]
        [ProducesResponseType(404)]
        public IActionResult RemoveById(int id)
        {
            var player = _context.RemovePlayerById(id);
            return player == default ? NotFound(player) : Ok(player);
        }
    }

}