
using System;
using System.Collections.Generic;
using System.Linq;
using BasketAPI.Models;
namespace BasketAPI.Data
{
    public class PlayerContext:IPlayerContext
    {
        
            private List<Player> _play;
            private readonly IPlayerContext _playerContext;
            public PlayerContext (PlayerContext playerContext)
            {
                _playerContext = playerContext;
                _play = new List<Player>()
                {
                    new Player("Danil Glazunow",13, 191),
                    new Player("MechiSlavas Matula",7, 190),
                    new Player("Viktor Korolkov",17, 183),
                    new Player("Dima Dubrovin",12, 185),
                    new Player("Nikola Mamonov",1, 180),
                };
            }

            public IEnumerable<Player> GetAllPlayer()
            {
                return _play.Select(p => p).ToList();
            }

            public Player? GetPlayerById(int Id)
            {
                return _play.FirstOrDefault(p => p.ID == Id);
            }

            

            public Player? GetPlayerByNumber(int number)
            {
                return _play.FirstOrDefault(p => p.Number.Equals(number));
            }

            public Player? RemovePlayerById(int id)
            {
                var player = _play.FirstOrDefault(p => p.ID == id);
                if (player != default)
                {
                    _play.Remove(player);
                }
                return player;
            }

            public Player AddPlayer(Player player)
            {
                throw new NotImplementedException();
            }
        }

        

        
    }
