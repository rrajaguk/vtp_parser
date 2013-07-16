using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser;
using RunnerParser.ObjRepresentation;

namespace VTP_parser.VisualAdapter
{
    public class TestMergeRepresentation
    {
        public string TestName { get; set; }
        public Boolean isSame { get; set; }
    }
    public enum mergeResultType {success,mismatch}

    public class TestMergeComparer : IComparer<TestMerge>{

        public static int Compare(bool x, bool y)
        {
            if (x && !y)
            {
                return 1;
            }
            if (x && y)
            {
                return 0;
            }
            if (!x && !y){
                return 0;
            }
            return -1;
        }

        public int Compare(TestMerge x, TestMerge y)
        {
            return TestMergeComparer.Compare(x.isSame(), y.isSame());
        }
    }
    public class TestMergeAdapter
    {
        public static List<TestMergeRepresentation> Adapt(MergeResult mr,mergeResultType mrType)
        {
            List<TestMergeRepresentation> result = new List<TestMergeRepresentation>();
            List<TestMerge> toAdapt = null;
            switch (mrType)
            {
                case mergeResultType.success:
                    toAdapt = mr.Success;
                    break;
                case mergeResultType.mismatch:
                    toAdapt = mr.UnmacthedContent;
                    break;
            }

            foreach (var merRes in toAdapt)
            {
                result.Add(new TestMergeRepresentation()
                {
                    TestName = merRes.ToString(),
                    isSame = merRes.isSame()
                });
            }
            result.Sort((p1, p2) => TestMergeComparer.Compare(p1.isSame,p2.isSame));
            toAdapt.Sort(new TestMergeComparer());
            return result;
        }
     
    }
}
