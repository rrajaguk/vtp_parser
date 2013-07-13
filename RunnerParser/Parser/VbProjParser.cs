using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RunnerParser.ObjComparer;
using RunnerParser.ObjRepresentation;
using RunnerParser.ObjRepresentation.objDecorator;

namespace RunnerParser
{
    public class VbProjParser
    {
        private System.IO.StreamReader file;
        private List<string> TestsFileNames;
        public List<TestCase> TestCases;
        private string workingPath;
        public VbProjParser(string workingPath, string projectName)
        {
            this.workingPath = workingPath;
            file = new System.IO.StreamReader(workingPath + projectName);
            TestsFileNames = new List<string>();
            TestCases = new List<TestCase>();
        }
        public void Parse()
        {
            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            xmlDoc.Load(file); // Load the XML document from the specified file

            // Get elements
            XmlNodeList filesToCompile= xmlDoc.GetElementsByTagName("Compile");
            TestsFileNames.Clear();

            foreach (XmlNode fileComp in filesToCompile)
            {
                if (fileComp.Attributes.GetNamedItem("Include").InnerText.Contains("SCR"))
                {
                    var FileName = fileComp.Attributes.GetNamedItem("Include").InnerText;
                    //Console.WriteLine(FileName);
                    TestsFileNames.Add(FileName);
                }
            }
            //Console.WriteLine("Number of tests = " + TestsFileNames.Count);
            checkTest();
            TestCases.Sort(new PhysicalFileNameComparer());
        }
        private void checkTest()
        {
            if (TestsFileNames.Count > 0)
            {
                foreach (var testName in TestsFileNames){
                    System.IO.StreamReader fileReader = new System.IO.StreamReader(workingPath + "\\" + testName);
                    bool keepReading = true;

                    var TestReaded = new TestCase(new VBTestIdentifier());
                    while (keepReading)
                    {
                        var lineReaded = fileReader.ReadLine();
                        if (lineReaded.Contains("'@FILE_NAME"))
                        {
                            TestReaded.TestFileName = lineReaded.Replace("'@FILE_NAME", " ").Trim();
                        }
                        if (lineReaded.Contains("'@TEST_NAME"))
                        {
                            TestReaded.TestName= lineReaded.Replace("'@TEST_NAME", " ").Trim();
                        }
                        if (lineReaded.Contains("'@TEST_DOMAINE"))
                        {
                            TestReaded.TestDomain = lineReaded.Replace("'@TEST_DOMAINE", " ").Trim();
                        }
                        if (lineReaded.Contains("'@TEST_BEHAVIOR"))
                        {
                            if (TestReaded.TestBehaviour != null && TestReaded.TestBehaviour.Count() > 0)
                            {
                                TestReaded.TestBehaviour += " ";
                            }
                            TestReaded.TestBehaviour += lineReaded.Replace("'@TEST_BEHAVIOR", " ").Trim();
                        }
                        if (lineReaded.Contains("'@DESCRIPTION"))
                        {
                            if (TestReaded.TestDescription != null && TestReaded.TestDescription.Count() > 0)
                            {
                                TestReaded.TestDescription += " ";
                            }
                            TestReaded.TestDescription+= lineReaded.Replace("'@DESCRIPTION", " ").Trim();
                        }
                        TestReaded.TestPhysicalFileName = testName;
                        var endsQC = lineReaded.Contains("@EndQC");
                        keepReading = !(!fileReader.EndOfStream && endsQC);
                    }
                    //Console.WriteLine("File Name = " + TestReaded.TestFileName);
                    //Console.WriteLine("Test Domain= " + TestReaded.TestDomain);
                    //Console.WriteLine("Test Behaviour= " + TestReaded.TestBehaviour);
                    //Console.WriteLine("Test Description= " + TestReaded.TestDescription);
                    TestCases.Add(TestReaded);
                }
            }
        }
    }
}
