using System;

namespace SchoolExampleAPI.Model
{
    public abstract class PersonalInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}