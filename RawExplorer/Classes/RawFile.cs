using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawExplorer.Classes
{
    public class RawFile
    {
        public string PicPath { get; }
        public string RawPath { get; }

        public RawFile(string pic, string raw) // возможно придеться изменить
        {
            PicPath = pic;
            RawPath = raw;
        }

        public override string ToString()
        {
            return PicPath;
        }
    }
}
