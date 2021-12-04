using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.ConsoleApp.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CategoryIdCategory { get; set; }

        public virtual Category CategoryIdCategoryNavigation { get; set; }
    }
}
