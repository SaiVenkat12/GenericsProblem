using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Sort<T> where T : IComparable
    {
        List<T> list;
        public Sort(List<T> list)
        {
            this.list = list;
        }

        public static T FindMaxList(List<T> list)
        {
            list.Sort();
            return list.Last();
        }
    }
}
