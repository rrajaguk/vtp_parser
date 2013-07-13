using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerParser.ObjRepresentation.objDecorator
{
    public interface ITestIdentifier
    {
        string getTestIdentifier(TestCase tc);
    }
}
