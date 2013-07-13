using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunnerParser.ObjRepresentation;

namespace RunnerParser.ObjComparer
{
    public class PhysicalFileNameComparer : IComparer<TestCase>
    {

        public int Compare(TestCase x, TestCase y)
        {
            string valX = x.TestPhysicalFileName;
            string valY = y.TestPhysicalFileName;
            int position = 0;
            
            if (valX == null && valY == null){
                return 0;
            }
            if (valX == null)
            {
                return -1;
            }
            if (valY == null)
            {
                return 1;
            }
            position = valX.LastIndexOf('\\');
            if (position > -1)
            {
                valX = valX.Substring(position);
            }

            position = valY.LastIndexOf('\\');
            if (position > -1)
            {
                valY = valY.Substring(position);
            }

            return valX.CompareTo(valY);
        }

        public static string extractFileNameOnly(string val)
        {
            int position = val.LastIndexOf('\\');
            if (position > -1)
            {
                val = val.Substring(position).Replace(".vb","");
            }
            return val.Replace("\\","");
        }
    }
}
