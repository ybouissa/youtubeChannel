using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.ConsoleApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Students = new HashSet<Student>();
        }

        public int IdCategory { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
