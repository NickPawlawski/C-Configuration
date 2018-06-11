using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareConfiguation
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigReader cr = ConfigReader.GetConfigReader();
        
            Reporter.Reporter.StartReporter(cr.FolderName);

            Console.WriteLine(SoftwareConfiguration.TestValue);
            Console.ReadLine();

        }
    }
}
