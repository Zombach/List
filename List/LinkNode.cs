using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkNode
    {
        public int Value { get; set; }
        public LinkNode LinkNext;

        public LinkNode(int value)
        {
            Value = value;
            LinkNext = null;
        }
    }
}
