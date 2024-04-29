using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Lecture : Entity
    {
        public string? Topic { get; set; }

        public Lecture()
        {

        }

        public Lecture(string? description, string? topic) : base(description)
        {
            Topic = topic;
        }
    }
}
