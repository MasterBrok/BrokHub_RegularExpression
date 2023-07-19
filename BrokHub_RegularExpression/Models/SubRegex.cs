
namespace BrokHub_RegularExpression.Models
{
    public class SubRegex
    {
        // SubRegex.Code == Regex.Code
        public int Code { get; set; }
        public string? SubTitle { get; set; }
        public string? SubDescription { get; set; }
        public string? Regex { get; set; }
        public SubRegex()
        {
                
        }

        public SubRegex(int code, string? subTitle, string? subDescription, string? regex)
        {
            Code = code;
            SubTitle = subTitle;
            SubDescription = subDescription;
            Regex = regex;
        }
    }
}
