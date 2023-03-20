using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9__28._02._23_
{
    internal class DVD: Disk, IRomoveableDisk
    {
        public string Name { get; set; }
        bool hasDisk;
        public bool HasDisk { get; } = true;
        public DVD () { }
        public DVD(string? name, string? memory, int memSize) : base(memory, memSize)
        {
            Name = name;
        }

        public new string GetName()
        {
            return Name;
        }
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine($"DVD: {Name} Inserted");
        }
        public void Reject()
        {
            hasDisk = false;
            Console.WriteLine($"DVD: {Name} Rejected");
        }
    }
}
