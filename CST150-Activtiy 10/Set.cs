using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST150_Activtiy_10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;


            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                //if Val is not equal to elements then the statement
                //would be false. No else statement required
                if (val == elements[i])
                    return true;
                //else
                // return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach(int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        //We would create set of union of A and B without altering the other sets
        public Set union(Set rhs)
        {
            Set C = new Set();
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                C.addElement(rhs.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++)
            {
                C.addElement(this.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            return C;
        }
    }
}

