using System.Collections.Generic;
using BasketAPI.Data;
using BasketAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasketAPI.Controllers
{
    
        [ApiController]
        public class ClubApiController : ControllerBase
        {
            private readonly IClubContext _context;

            public ClubApiController(IClubContext context)
            {
                _context = context;
            }

            [HttpGet("api/club")]
            [ProducesResponseType(200, Type = typeof(IEnumerable<Club>))]
            [ProducesResponseType(404)]
            public IActionResult GetAll()
            {
                return Ok(_context.GetAllClub());
            }

            [HttpGet("api/club/{id}")]
            [ProducesResponseType(200, Type = typeof(Club))]
            [ProducesResponseType(404)]
            public IActionResult GetById(int id)
            {
                var club = _context.GetClubById(id);
                return club == default ? NotFound(club) : Ok(club);
            }

            [HttpGet("api/club/titile/{title}")]
            [ProducesResponseType(200, Type = typeof(Club))]
            [ProducesResponseType(404)]
            public IActionResult GetByClub(string title)
            {
                var  club = _context.GetClubByTitle(title);
                return club == default ? NotFound(title) : Ok(title);
            }

            [HttpGet("api/club/remove/{id}")]
            [ProducesResponseType(200, Type = typeof(Club))]
            [ProducesResponseType(404)]
            public IActionResult RemoveById(int id)
            {
                var club = _context.RemoveClubById(id);
                return club == default ? NotFound(club) : Ok(club);
            }
    }
}