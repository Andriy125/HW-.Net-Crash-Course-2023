using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_10__02._03._23_
{
    internal class Director : ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public object Clone() => new Director { FirstName = this.FirstName, LastName = this.LastName };
        public override string ToString() => $"FirstName: {FirstName}, LastName {LastName}";


    }
}
