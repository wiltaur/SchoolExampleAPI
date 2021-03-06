using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolExampleAPI.Model
{
    public partial class Rol
    {
        public Rol()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
