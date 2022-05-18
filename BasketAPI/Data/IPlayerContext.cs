using System.Collections.Generic;
using BasketAPI.Models;

namespace BasketAPI.Data
{
    public interface IPlayerContext
    {
        public IEnumerable<Player> GetAllPlayer();
        public Player? GetPlayerById(int Id);
        public Player? GetPlayerByNumber(int number);
        public Player? RemovePlayerById(int id);
        public Player AddPlayer(Player player);
    }
}