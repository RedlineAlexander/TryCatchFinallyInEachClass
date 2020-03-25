using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace IEnumerableIEnumerator
{
    class Week : IEnumerable
    {
        string[] stringweek = { "Monday, Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return stringweek.GetEnumerator();
        }
    }
}
