using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prakt3.models
{
    class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
    }
}
