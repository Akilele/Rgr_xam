using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prakt3.models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public string Descripton { get; set; }
    }
}
