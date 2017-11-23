using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ListVisitor : IVisitor
    {
        private string currentdir = "";

        public void Visit(IFile file)
        {
            Console.WriteLine(currentdir + "/" + ToString(file));
        }

        public void Visit (IDirectory directory)
        {
			Console.WriteLine(currentdir + "/" + ToString(directory));
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.Name;
            IEnumerator it = directory.GetEnumerator();

            while (it.MoveNext())
            {
                IEntry entry = (IEntry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }

		public static string ToString(IEntry entry)
		{
			return entry.Name + " (" + entry.GetSize() + ")";
		}


	}
}
