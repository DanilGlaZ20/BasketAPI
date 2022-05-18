
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;

namespace BasketAPI.Models
{
    public class Club
    {
        private static int idstat = 0;

        public Club(string title, int year_of_foundation, int number_of_player)
        {
            ID = ++idstat;
            Title = title;
            Year_of_Foundation = year_of_foundation;
            Number_of_Player = number_of_player;
        }
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year_of_Foundation { get;set; }
        public int Number_of_Player {get;set; }
        
    }
}