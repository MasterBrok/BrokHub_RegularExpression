
using System.Collections.Generic;

namespace BrokHub_RegularExpression.Models
{
    public class Regex
    {
        public string? Title { get; set; }
        public int? Code { get; set; }
        public string? Description { get; set; }
        public List<SubRegex>? SubRegex{ get; set; }
        public Regex()
        {
                
        }

        public Regex(string? title, int? code, string? description, List<SubRegex>? subRegex)
        {
            Title = title;
            Code = code;
            Description = description;
            SubRegex = subRegex;
        }
    }
}
