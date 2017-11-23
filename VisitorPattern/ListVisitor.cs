using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ListVisitor :Visitor
    {
        private string currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine(currentdir + "/" + ToString(file));
        }

        public override void Visit (Directory directory)
        {
			Console.WriteLine(currentdir + "/" + ToString(directory));
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.Name;
            IEnumerator it = directory.GetEnumerator();

            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }

		public static string ToString(Entry entry)
		{
			return entry.Name + " (" + entry.GetSize() + ")";
		}


	}
}
