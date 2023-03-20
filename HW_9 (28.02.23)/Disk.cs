using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9__28._02._23_
{
    interface IRomoveableDisk
    {
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }

    interface IDisk
    {
        public string Read();
        public void Write(string text);
    }
    internal class Disk : IDisk
    {
        string? memory;
        int memSize;

        public string? Memory { get; set; }
        public int MemSize { get; set; }


        public Disk() { }
        
        

        public Disk (string? memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public string GetName ()
        {
            return $"Ім'я диску: --";
        }
        public string Read()
        {
            return $"Reading device";
        }
        public void Write(string text)
        {
            Console.WriteLine("Write Data...");
        }

    }
}
