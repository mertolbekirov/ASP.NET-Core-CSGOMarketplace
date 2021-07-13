﻿using System.Collections.Generic;

namespace CSGOMarketplace.Data.Models
{
    public class Condition
    {

        public int Id { get; init; }

        public string Name { get; set; }

        public IEnumerable<Sale> Cars { get; init; } = new List<Sale>();
    }
}
