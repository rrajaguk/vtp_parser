using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser.Helper;

namespace RunnerParser.ObjRepresentation
{
    public class TestMerge
    {
        public TestCase vbSource { get; set; }
        public TestCase excelSource { get; set; }
        public bool isSame()
        {
            // compare domain
            string val1, val2;
            val1 = vbSource.TestDomain;
            val2 = excelSource.TestDomain;
            if (string.Compare(val1, val2, true) != 0)
            {
                return false;
            }            
            // compare behaviour
            val1 = StringHelper.trimPunctiationAndSpaces(vbSource.TestBehaviour);
            val2 = StringHelper.trimPunctiationAndSpaces(excelSource.TestBehaviour);
            if (string.Compare(val1, val2, true) != 0)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return excelSource.TestName;
        }
    }
}
