﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AspNetCoreAngularCrudDemo.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

        public virtual Position Position { get; set; }

        public decimal GoalsPerMatch => Math.Round((decimal)Goals / (decimal)Appearances, 2);

    }
}
