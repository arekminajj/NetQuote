using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetQuote.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
