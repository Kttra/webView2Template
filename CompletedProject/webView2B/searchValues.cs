using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webView2B
{
    [Serializable]
    class searchValues
    {
        public int edge;
        public int desktop;
        public int mobile;
    //Create class with no entries: searchValues newEntry = new searchValues();
    public searchValues()
    {

    }
    //Create class with entries: searchValues newEntry = new searchValues(10, 10, 10);
    public searchValues(int aEdge, int aDesktop, int aMobile)
    {
        edge = aEdge;
        desktop = aDesktop;
        mobile = aMobile;
    }
    }
}
