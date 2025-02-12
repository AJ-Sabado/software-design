using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TextBook : Book
    {
        public string? Subject { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Subject: {Subject}";
        }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Subject))
                throw new ArgumentNullException("Subject");
        }
    }
}
