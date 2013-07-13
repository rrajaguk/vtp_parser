using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerParser.Helper
{
    public class StringHelper
    {
        public static string trimPunctiationAndSpaces(string val)
        {
            var sb = new StringBuilder();

            foreach (char c in val)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
