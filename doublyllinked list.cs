using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace phase1_doublylist
{
    public class doublyllinked_list
    {
        private node root = null;
        private node current = null;
        private int length;

        public node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public node getCurrent()
        {
            return this.current;
        }

        public node getRoot()
        {
            current = root;
            return this.root;
        }

        public node getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public node getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }

    }
}
