using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolExampleAPI.Model
{
    public partial class User
    {
        public User()
        {
            Areas = new HashSet<Area>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
    }
}