using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Directory:Entry
    {
        private ArrayList dir = new ArrayList();
    
        public Directory(string name) : base(name)
        {
        }

        public override int GetSize()
        {
            int size = 0;
            IEnumerator it = dir.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.GetSize();
            }
            return size;
        }

         public new Entry Add(Entry entry)
        {
            dir.Add(entry);
            return this;
        }

        public IEnumerator GetEnumerator()
        {
            return dir.GetEnumerator();
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
