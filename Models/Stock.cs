// ? prop <- to create a property in C#

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] // set exact decimal to Purchase
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")] // set exact decimal to LasDiv
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; } // long

        // 1-to-many relationship
        // 1 Stock can have many Comments
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}