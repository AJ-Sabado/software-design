using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ebook : Book
    {
        public string? Platform { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Platform: {Platform}";
        }
    }
    
}
