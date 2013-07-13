using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser.ObjComparer;
using RunnerParser.ObjRepresentation;

namespace RunnerParser
{
    public class MergeResult
    {
        public List<TestMerge> Success { get; set; }
        public List<TestMerge> UnmacthedContent { get; set; }
        public List<TestCase> UnmacthedExcel { get; set; }
        public List<TestCase> UnmacthedVB { get; set; }
        public MergeResult(VbProjParser vbProj, ExcelParser excelProj)
        {
            Success = new List<TestMerge>();
            UnmacthedContent = new List<TestMerge>();
            UnmacthedExcel = new List<TestCase>();
            UnmacthedVB = new List<TestCase>();

            // do mapping for excel
            PhysicalFileNameComparer comparer = new PhysicalFileNameComparer();
            foreach (var currrentExcel in excelProj.TestCases)
            {
                int indexTraverse = 0;
                string excelTestName = currrentExcel.TestName;
                while (indexTraverse < vbProj.TestCases.Count)
                {
                    TestCase currentVB = vbProj.TestCases[indexTraverse];
                    string vbTestName = PhysicalFileNameComparer.extractFileNameOnly(currentVB.TestPhysicalFileName);
                    int valo = string.Compare(excelTestName, vbTestName, false);

                    if (valo == 0)
                    {
                        currrentExcel.isMatch = true;
                        currentVB.isMatch = true;
                        TestMerge resultMerge =new TestMerge() { excelSource = currrentExcel, vbSource = currentVB }; 
                        if (resultMerge.isSame()){
                            Success.Add(resultMerge);
                        }
                        else {
                            UnmacthedContent.Add(resultMerge);
                        }
                        break;
                    }
                    if (valo < 0)
                    {
                        break;
                    }
                    indexTraverse++;
                }
            }
            excelProj.TestCases.RemoveAll(p => p.isMatch);
            UnmacthedExcel = excelProj.TestCases;

            vbProj.TestCases.RemoveAll(p => p.isMatch);
            UnmacthedVB= vbProj.TestCases;

        }
    }
}
