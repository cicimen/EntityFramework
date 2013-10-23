using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Name { get; set; }

        public string Owner { get; set; }

        public bool IsResort { get; set; }


        [Required]
        public Destination Destination { get; set; }


        public decimal MilesFromNearestAirport { get; set; }
    }
}
