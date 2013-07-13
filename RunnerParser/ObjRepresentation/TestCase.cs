using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser.ObjRepresentation.objDecorator;

namespace RunnerParser.ObjRepresentation
{
    public class TestCase
    {
        public string TestName { get; set; }
        public string TestDomain { get; set; }
        public string TestFileName { get; set; }
        public string TestBehaviour { get; set; }
        public string TestDescription { get; set; }
        public string TestPhysicalFileName { get; set; }
        public Boolean isMatch { get; set; }
        public ITestIdentifier testIdentifier { get; set; }

        public TestCase(ITestIdentifier id)
        {
            this.testIdentifier = id;
            isMatch = false;
        }
        public override string ToString()
        {
            return testIdentifier.getTestIdentifier(this);
        }
    }
}
