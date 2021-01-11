using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawExplorer.Classes
{
    public class RawFile
    {
        public string JpgPath { get; }
        public string RawPath { get; }

        public RawFile(string jpg, string raw)
        {
            JpgPath = jpg;
            RawPath = raw;
        }

        public override string ToString()
        {
            return JpgPath;
        }
    }
}
