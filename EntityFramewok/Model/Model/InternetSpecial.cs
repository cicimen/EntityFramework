﻿using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class InternetSpecial
    {
        public int InternetSpecialId { get; set; }
        public int Nights { get; set; }
        public decimal CostUSD { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int AccommodationId { get; set; }
        [ForeignKey("AccommodationId")]
        public Lodging Accommodation { get; set; }
    }
}
