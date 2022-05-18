using System.Collections.Generic;
using BasketAPI.Models;

namespace BasketAPI.Data
{
    public interface IClubContext
    {
        public IEnumerable<Club> GetAllClub();
        public Club? GetClubById(int Id);
        public Club? GetClubByTitle(string title);
        public Club? RemoveClubById(int id);
        public Club AddClub(Club club);
    }
}