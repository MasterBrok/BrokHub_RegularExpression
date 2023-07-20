using System.Collections.Generic;
using BrokHub_RegularExpression.Models;

namespace BrokHub_RegularExpression.BrokData
{
    public class ListData
    {
        public List<Regex> Regexes = new List<Regex>()
        {
            new Regex(){Code = 1 , Title="Email",Description="Email Regex",SubRegex=EmailSub},
            new Regex(){Code = 2 , Title="PhoneNumber",Description="PhoneNumber Regex",SubRegex=PhoneNumberSub},
            new Regex(){Code = 4 , Title="Url",Description="Url Regex",SubRegex=UrlSub}
        };

        private static List<SubRegex> EmailSub = new List<SubRegex>()
        {
            new SubRegex(1,"Email Pattern 1","Matches email addresses.","^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"),
            new SubRegex(1,"Email Pattern 2","Matches email addresses `with` subdomains.","^[a-zA-Z0-9._%+-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,}$"),
            new SubRegex(1,"Email Pattern 3","Matches email addresses with two to five-letter top-level domains. ","^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,5}$"),
            new SubRegex(1,"Email Pattern 4","Matches email addresses with common top-level domains (com, net, org, io, edu, gov).","^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.(com|net|org|io|edu|gov)$")
        };
        private static List<SubRegex> PhoneNumberSub = new List<SubRegex>()
        {
            new SubRegex(2,"Mobile Number Pattern 1","Matches Iranian mobile numbers starting with 09 followed by nine digits.","^09\\d{9}$"),
            new SubRegex(2,"Mobile Number Pattern 2","Matches Iranian mobile numbers in international format starting with +989 followed by nine digits.","^\\+989\\d{9}$"),
        };
        private static List<SubRegex> UrlSub = new List<SubRegex>()
        {
            new SubRegex(4,"URL Pattern 2","Matches internet URLs starting with \"http://\" or \"https://\" or \"ftp://\" and must contain at least one character after the domain name with no white spaces.","^(https?|ftp)://[^\\s/$.?#].[^\\s]*$"),
            new SubRegex(4,"URL Pattern 3","Matches internet URLs starting with \"http://\" or \"https://\" and must contain at least one character after the domain name with optional path after the domain.","^https?://[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}(/[^\\s]*)?$")
        };
    }
}
