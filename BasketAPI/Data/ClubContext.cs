using System;
using System.Collections.Generic;
using System.Linq;
using BasketAPI.Models;

namespace BasketAPI.Data
{
    public class ClubContext: IClubContext
    {
        private List<Club> _club;
        private readonly IClubContext _clubContext;
        public ClubContext (ClubContext clubContext)
        {
            _clubContext = clubContext;
            _club = new List<Club>()
            {
                new Club("4Лены в Огне",2022, 5),
                new Club("LOLkers",1966, 15),
                new Club("DreamTeam",2015, 12),
                new Club("Bobkens",1984, 10),
                new Club("Khimki",1997, 14),
            };
        }

        public IEnumerable<Club> GetAllClub()
        {
            return _club.Select(c => c).ToList();
        }

        

        public Club? GetClubById(int Id)
        {
            return _club.FirstOrDefault(p => p.ID == Id);
        }

            

        public Club? GetClubByTitle(string Title)
        {
            return _club.FirstOrDefault(c => c.Title.Equals(Title));
        }

        public Club? RemoveClubById(int id)
        {
            var club = _club.FirstOrDefault(c => c.ID == id);
            if (club != default)
            {
                _club.Remove(club);
            }
            return club;
        }

        public Club AddClub(Club club)
        {
            throw new NotImplementedException();
        }
    }
}