using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticClassTest
{
    public static class StaticClassAccessModel
    {
        public static void Fun()
        {
            StaticModel.fieldOne = "F1";
            StaticModel.fieldTwo = "F2";
        }
    }
}
