using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser.ObjRepresentation;

namespace RunnerParser.ObjComparer
{
    public class TestNameComparer : IComparer<TestCase>
    {
        public int Compare(TestCase x, TestCase y)
        {
            string valX = x.TestName;
            string valY = y.TestName;

            if (valX == null && valY == null)
            {
                return 0;
            }
            if (valX == null)
            {
                return -1;
            }
            if (valY == null)
            {
                return 1;
            }

            return valX.CompareTo(valY);
        }
    }
}
