using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Entity
    {
        public string? Description { get; set; }

        public Entity()
        {

        }

        public Entity(string? description)
        {
            Description = description;
        }
    }
}
