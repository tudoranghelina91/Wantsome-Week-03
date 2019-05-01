using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03
{
    public class SingleLinkedListNode
    {
        public int nodeData;
        public SingleLinkedListNode next;
        public SingleLinkedListNode(int data)
        {
            nodeData = data;
            next = null;
        }
    }
}
