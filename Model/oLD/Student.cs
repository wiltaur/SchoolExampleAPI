using System.Collections.Generic;

namespace SchoolExampleAPI.Model
{
    public class Student : PersonalInformation
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        public int ClassRoom { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}