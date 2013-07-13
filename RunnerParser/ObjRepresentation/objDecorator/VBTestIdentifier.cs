using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerParser.ObjRepresentation.objDecorator
{
    public class VBTestIdentifier : ITestIdentifier
    {
         public VBTestIdentifier()
        {
        }
         public string getTestIdentifier(TestCase ts)
        {
            return ts.TestFileName;
        }
    }
}
