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
            new Regex(){Code = 3 , Title="Name",Description="Name Regex",SubRegex=NameSub},
            new Regex(){Code = 4 , Title="Url",Description="Url Regex",SubRegex=UrlSub}
        };
        public static List<SubRegex> EmailSub = new List<SubRegex>()
        {
            new SubRegex(1,"E1","E1","E1"),
            new SubRegex(1,"E2","E2","E2"),
            new SubRegex(1,"E3","E3","E3"),
            new SubRegex(1,"E4","E4","E4")
        };
        public static List<SubRegex> PhoneNumberSub = new List<SubRegex>()
        {
            new SubRegex(2,"P1","P1","P1"),
            new SubRegex(2,"P2","P2","P2"),
            new SubRegex(2,"P3","P3","P3"),
        };

        public static List<SubRegex> NameSub = new List<SubRegex>()
        {
            new SubRegex(3,"N1","N1","N1"),
            new SubRegex(3,"N2","N2","N2"),
            new SubRegex(3,"N3","N3","N3")
        };
        public static List<SubRegex> UrlSub = new List<SubRegex>()
        {
            new SubRegex(4,"U1","U1","U1"),
            new SubRegex(4,"U2","U2","U2"),
            new SubRegex(4,"U3","U3","U3")
        };
    }
}
