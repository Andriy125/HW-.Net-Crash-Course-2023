using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_9__28._02._23_
{
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }
    internal class Printer: IPrintInformation
    {
        public string? Name;
        public string GetName()
        {
            return "Printer";
        }
        public void Print(string str)
        {
            Console.WriteLine($"Друкую через принтер наступне: {str}");
        }
       
    }

    internal class Monitore : IPrintInformation
    {
        public string? Name;
        public string GetName()
        {
            return "Monitor";
        }
        public void Print(string str)
        {
            Console.WriteLine($"'{str}' - була показана на монітор");
        }
    }
}
