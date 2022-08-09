using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GameNightWithFriends.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameNightId { get; set; }
        public GameNight GameNight { get; set; }
    }
}