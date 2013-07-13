using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using RunnerParser.ObjComparer;
using RunnerParser.ObjRepresentation;

namespace RunnerParser
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ExcelParser excelFileParser = new ExcelParser(@"C:\Users\Ronald\Documents\MultiImsiV2\com\ProductDoc\Val\VTP_VTR\MultiImsiV2_001_VTP_VTR.xlsx");
            excelFileParser.Parse();
            VbProjParser vbProjectParser = new VbProjParser(@"C:\Users\Ronald\Documents\MultiImsiV2\valid\sc_valid_net\Stand_Prop_Projects\Mobcom\MultiIMSIV2\", "MultiIMSIV2.vbproj");
            vbProjectParser.Parse();

            //Console.WriteLine(excelFileParser.TestCases.Count);
            //Console.WriteLine(vbProjectParser.TestCases.Count);

            //Console.WriteLine(excelFileParser.TestCases[1].TestName);  h  6 
            
           List<TestMerge> MainTestCase = new List<TestMerge>();

            // do mapping for excel
            PhysicalFileNameComparer comparer = new PhysicalFileNameComparer();
            foreach (var currrentExcel in excelFileParser.TestCases)
            {
                int indexTraverse = 0;
                string excelTestName = currrentExcel.TestName;
                while (indexTraverse < vbProjectParser.TestCases.Count)
                {
                    TestCase currentVB = vbProjectParser.TestCases[indexTraverse];
                    string vbTestName = PhysicalFileNameComparer.extractFileNameOnly(currentVB.TestPhysicalFileName);
                    int valo = string.Compare(excelTestName, vbTestName, false);
                   
                    if (valo == 0)
                    {
                        currrentExcel.isMatch = true;
                        currentVB.isMatch = true;
                        MainTestCase.Add(new TestMerge() { excelSource = currrentExcel, vbSource = currentVB });
                        break;
                    } 
                    if (valo < 0)
                    {
                        break;
                    }
                    indexTraverse++;
                }
            }

            //removal of same test
            int removeFromExcel =  excelFileParser.TestCases.RemoveAll(p => p.isMatch);
            int removeFromVB = vbProjectParser.TestCases.RemoveAll(p => p.isMatch);
            
            // set the unmapped test
            Console.WriteLine("unmapped VB proj");
            foreach (var vpo in vbProjectParser.TestCases)
            {
                Console.WriteLine(vpo.TestPhysicalFileName);
            }
            Console.WriteLine("unmapped excel");
            foreach (var vpo in excelFileParser.TestCases)
            {
                Console.WriteLine(vpo.TestName);
            }
            // do mapping for the rest

            Console.ReadKey();
        }
    }
}
