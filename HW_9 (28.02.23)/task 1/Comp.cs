using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9__28._02._23_
{
    internal class Comp
    {
        int coutDisk = 0;
        int coutPrintDevice = 0;
        private List<Disk> disks;
        private List<IPrintInformation> printDevice;

        public Comp(List<Disk> disks, List<IPrintInformation> printDevice)
        {
            this.disks = disks;
            this.printDevice = printDevice;
        }
        public void AddDevice(int index, IPrintInformation si)
        {
            printDevice.Add(si);
        }

        public void AddDisk(int index, Disk d)
        {
            coutDisk++;
            disks.Add(d);
        }
        public void InsertReject(Disk disk, bool b)
        {
            if (!disks.Contains(disk))
                disks.Add(disk);
            else
                disks.Remove(disk);
        }
        public void PrintInfo(string text, IPrintInformation outputDevice)
        {
            outputDevice.Print(text);
        }
        public void ReadInfo(Disk disk)
        {
            disk.Read();
        }
        public void ShowDisk()
        {
            foreach (var i in disks)
            {
                Console.WriteLine($"Name: {i.GetName}\nMemory size: {i.MemSize}");
            }
        }
        public void ShowPrintDevice() 
        {
            foreach (var i in printDevice)
            {
                Console.WriteLine($"Name: {i.GetName}");
            }
        }
    }
}
