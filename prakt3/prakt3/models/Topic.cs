using System.ComponentModel.DataAnnotations;

namespace prakt3.models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}