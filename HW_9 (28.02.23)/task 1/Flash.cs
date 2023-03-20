﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_9__28._02._23_
{
    internal class Flash: Disk, IRomoveableDisk
    {
        public string Name { get; set; }
        bool hasDisk;
        public bool HasDisk { get; } = false;

        public Flash(string? name, string? memory, int memSize) : base(memory, memSize)
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
            Console.WriteLine($"Flash: {Name} Inserted");
        }
        public void Reject()
        {
            hasDisk = false;
            Console.WriteLine($"Flash: {Name} Rejected");
        }
    }
}
