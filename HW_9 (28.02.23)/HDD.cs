using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9__28._02._23_
{
    internal class HDD : Disk
    {
        public string Name { get; set; }
        public HDD() { }
        public HDD(string? name, string? memory, int memSize) : base(memory, memSize)
        {
            Name = name;
        }
        public new string GetName() { return Name; }

    }
}
