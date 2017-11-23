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
        private List<IEntry> childEntries = new List<IEntry>();

		public string Name { get; }

		public Directory(string name)
        {
			Name = name;
        }

        public int GetSize()
        {
            int size = 0;
			foreach (var entry in childEntries)
			{
				size += entry.GetSize();
			}

			return size;
        }

        public void Add(IEntry entry)
        {
            childEntries.Add(entry);
        }

        public IEnumerator GetEnumerator()
        {
            return childEntries.GetEnumerator();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
