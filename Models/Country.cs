using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Models
{
    public class Country : Entity
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
