using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuzLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bString = "sunkist";
            Process.Start("Neuz.exe", bString);
            Environment.Exit(0);
        }
    }
}
