using System;
using SQLite;

namespace Clothes.Models
{
    public class Clothe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Date { get; set; }



        public string Type { get; set; }
        public string Brand { get; set; }
        public string Characteristics { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string TicketPrice { get; set; }
        public string PaidPrice { get; set; }

        public string Margin { get; set; }

        public string SuggestedPrice { get; set; }

        public string Text { get; set; }
    }
}
