using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolExampleAPI.Model
{
    public partial class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUser { get; set; }
        public int IdCourse { get; set; }

        public virtual Course IdCourseNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
