using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolExampleAPI.Model
{
    public partial class Course
    {
        public Course()
        {
            Areas = new HashSet<Area>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
    }
}
