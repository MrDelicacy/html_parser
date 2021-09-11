using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_1.Core
{
    class ParsingInformation
    {
        public string Name { get; set; }
        public List<ParsingInformation> Nodes { get; set; }
    }
}
