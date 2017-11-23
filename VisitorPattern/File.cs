using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class File : IFile
    {
        private int Size { get; }

		public string Name { get; }

		public File(string name,int size)
        {
			Name = name;
            Size = size;
        }

        public int GetSize()
        {
            return Size;
        }

        public void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    } 
}
