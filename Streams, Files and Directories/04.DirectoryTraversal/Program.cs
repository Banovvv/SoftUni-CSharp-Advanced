using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            throw new NotImplementedException();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            throw new NotImplementedException();
        }

    }
}
