using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Entry
    {
        public string Name { get; }
        public abstract int GetSize();

		public Entry(string name)
		{
			Name = name;
		}

		public Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public IEnumerator Enumerator()
        {
            throw new FileTreatmentException();
        }

        public override string ToString()
        {
            return Name + " (" + GetSize() + ")";
        }

        public abstract void Accept(Visitor v);
    }
}
