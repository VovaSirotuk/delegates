using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class OverflowedEventArgs
    {
        public string Message { get; set; }
        public int CountElemets { get; set; }
        public int Size { get; set; }
        public OverflowedEventArgs(string mes, int count,int size)
        {
            Message = mes;
            CountElemets = count;
            Size = size;
        }
        public OverflowedEventArgs(string mes)
        {
            Message = mes;
        }
    }
}
