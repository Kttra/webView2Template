using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    progressB class file
*/

namespace webView2B
{
    [Serializable]
    class progressB
    {
        public int maximum;
        public int minimum;
        public int value;

    //Create class with no entries: progressB newEntry = new progressB();
    public progressB()
    {

    }
    //Create class with entries: progressB newEntry = new progressB(10, 10, 10);
    public progressB(int aMaximum, int aMinimum, int aValue)
    {
        maximum = aMaximum;
        minimum = aMinimum;
        value = aValue;
    }
    }
}
