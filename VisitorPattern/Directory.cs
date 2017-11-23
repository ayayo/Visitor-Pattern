using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Directory: IDirectory
    {
        private ArrayList dir = new ArrayList();

		public string Name { get; }

		public Directory(string name)
        {
			Name = name;
        }

        public int GetSize()
        {
            int size = 0;
            IEnumerator it = dir.GetEnumerator();
            while (it.MoveNext())
            {
                IEntry entry = (IEntry)it.Current;
                size += entry.GetSize();
            }
            return size;
        }

        public IEntry Add(IEntry entry)
        {
            dir.Add(entry);
            return this;
        }

        public IEnumerator GetEnumerator()
        {
            return dir.GetEnumerator();
        }

        public void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
