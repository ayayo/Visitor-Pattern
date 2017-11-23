using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class File :Entry
    {
        private int size;
        public File(string name,int size) : base(name)
        {
            this.size = size;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    } 
}
