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
        public abstract string GetName();
        public abstract int GetSize();
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
            return GetName() + " (" + GetSize() + ")";
        }

        public abstract void Accept(Visitor v);
    }
}
