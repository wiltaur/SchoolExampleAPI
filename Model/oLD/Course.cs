namespace SchoolExampleAPI.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Student IdStudentNavigation { get; set; }
        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
