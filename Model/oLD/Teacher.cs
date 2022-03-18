using System.Collections.Generic;

namespace SchoolExampleAPI.Model
{
    public class Teacher : PersonalInformation
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }
        public virtual ICollection<Course> Courses { get; set; }
    }
}