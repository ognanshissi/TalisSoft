using System.Collections.Generic;

namespace TalisSoft.Common.Application.Models.Mail
{
    public class Email
    {
        public ICollection<string> To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
    }
}