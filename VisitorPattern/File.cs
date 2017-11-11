using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class File :Entry
    {
        private string name;
        private int size;
        public File(string name,int size)
        {
            this.name = name;
            this.size = size;
        }

        public override string GetName()
        {
            return name;
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
