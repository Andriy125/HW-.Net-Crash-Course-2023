using HW_9__28._02._23_;

HDD hdd = new HDD()
{
    Memory = "0110101",
    MemSize = 250
};
DVD dvd = new DVD()
{
    Memory = "00000000000011111",
    MemSize = 5
};
Printer printer = new Printer();
Monitore monitor = new Monitore();

List<Disk> disks = new List<Disk>
{
    hdd, dvd
};

List<IPrintInformation> printDevice = new List<IPrintInformation>
{
    printer, monitor
};

Comp computer = new Comp(disks, printDevice);
computer.PrintInfo("123", printDevice[0]);