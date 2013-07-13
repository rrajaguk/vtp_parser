using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.XSSF.UserModel;
using RunnerParser.ObjComparer;
using RunnerParser.ObjRepresentation;
using RunnerParser.ObjRepresentation.objDecorator;

namespace RunnerParser
{
    public class ExcelParser
    {
        private int SystemTestRowName;
        private int SystemTestRowObjective;
        private int SystemTestRowDomain;
        private XSSFWorkbook template;
        public List<TestCase> TestCases; 
        public ExcelParser(string fileName)
        {

            FileStream fs = new FileStream(fileName,
           FileMode.Open);
           template = new XSSFWorkbook(fs);
           TestCases = new List<TestCase>();
        }
        public void Parse()
        {
            XSSFSheet sheet = (XSSFSheet)template.GetSheet("VTR System");

            //header processing
            XSSFRow dataRow = (XSSFRow)sheet.GetRow(0);

            var dm = dataRow.GetEnumerator();

            int counter = 0;
            while (dm.MoveNext())
            {
                string cellVal = ((XSSFCell)dm.Current).StringCellValue;
                if (cellVal.ToLower().Trim() == "system test name")
                {
                    SystemTestRowName = counter;
                    Console.WriteLine(cellVal);
                }
                if (cellVal.ToLower().Trim() == "test objective")
                {
                    SystemTestRowObjective = counter;
                    Console.WriteLine(cellVal);
                }
                if (cellVal.ToLower().Trim() == "requirement domain")
                {
                    SystemTestRowDomain = counter;
                }
                counter++;
            }

            // body processing
            bool FoundEmptyTestName = true;
            int emptyCounter = 0;
            counter = 1;
            while (FoundEmptyTestName)
            {
                dataRow = (XSSFRow)sheet.GetRow(counter);
                string TestName = dataRow.GetCell(SystemTestRowName).StringCellValue;
                string TestObjective = dataRow.GetCell(SystemTestRowObjective).StringCellValue;
                string TestDomain = dataRow.GetCell(SystemTestRowDomain).StringCellValue;
                if (TestName.Trim().Count() > 0) {
                    TestCase CurrentTestCase = new TestCase(new ExcelTestIdentifier());
                    CurrentTestCase.TestName = TestName;
                    CurrentTestCase.TestDomain = TestDomain;
                    CurrentTestCase.TestBehaviour = TestObjective;
                    TestCases.Add(CurrentTestCase);
                }
                if (TestName.Count() == 0)
                {
                    emptyCounter++;
                }
                else
                {
                    emptyCounter = 0;
                }

                FoundEmptyTestName = !(emptyCounter > 2);
                counter++;

            }
            //sort the testcases based on name
            TestCases.Sort(new TestNameComparer());
        }
    }
}
