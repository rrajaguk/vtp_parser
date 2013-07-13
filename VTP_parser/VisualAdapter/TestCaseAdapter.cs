using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser;
using RunnerParser.ObjRepresentation;

namespace VTP_parser.VisualAdapter
{
    public class TestCaseRepresentation
    {
        public string TestName { get; set; }
    }
    public enum resultType
    {
        Excel,
        VB
    }
    
    public class TestCaseAdapter
    {
        public static List<TestCaseRepresentation> Adapt(MergeResult mr, resultType rt)
        {

            List<TestCaseRepresentation> result = new List<TestCaseRepresentation>();
            List<TestCase> testCases;
            switch (rt)
            {
                case resultType.Excel:
                    testCases = mr.UnmacthedExcel;
                    break;
                default:
                    testCases = mr.UnmacthedVB;
                    break;
            }
            foreach (var merRes in testCases)
            {
                result.Add(new TestCaseRepresentation()
                {
                    TestName = merRes.ToString()
                });
            }
            return result;
        }
    }
}
