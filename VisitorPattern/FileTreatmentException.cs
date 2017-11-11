using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException()
        {

        }

        public FileTreatmentException(string msg) : base(msg)
        {
            
        }
        
    }
}
