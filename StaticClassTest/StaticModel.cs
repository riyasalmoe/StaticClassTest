using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticClassTest
{
    public static class StaticModel
    {
        public static string fieldOne = "Field One";
        public static string fieldTwo = "Field Two";
    }

    public class Test
    {

        public string F1 { get; set; } = StaticModel.fieldOne;
        public string F2 { get; set; } = StaticModel.fieldTwo;

        public Test()
        {
            StaticModel.fieldOne = "FieldOne Value Changed";
            StaticModel.fieldTwo = "FieldTwo Value Changed";
        }


    }
}
