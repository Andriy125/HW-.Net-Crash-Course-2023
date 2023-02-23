Weapon weapon1 = new Weapon();
Weapon weapon2 = new Weapon();

weapon1.Initialize(1000, 0.50, 30);
weapon2.Initialize(-10, 0.45, 20);

Console.WriteLine($"Weapon 1: range = {weapon1.GetRange()}, caliber = {weapon1.GetCaliber()}, bullets = {weapon1.GetBullets()}, " +
    $"max bullets = {weapon1.GetMaxBullets()}");

Console.WriteLine($"Weapon 2: range = {weapon2.GetRange()}, caliber = {weapon2.GetCaliber()}, bullets = {weapon2.GetBullets()}, " +
    $"max bullets = {weapon2.GetMaxBullets()}");

Console.WriteLine($"Weapon 1 shot: {weapon1.Shot()}");
Console.WriteLine($"Weapon 1 shot: {weapon1.Shot()}");
Console.WriteLine($"Weapon 1 shot: {weapon1.Shot()}");
Console.WriteLine($"Weapon 1 shot: {weapon1.Shot()}");

weapon1.Recharge();
Console.WriteLine($"Weapon 1 recharged, bullets = {weapon1.GetBullets()}");

weapon1.Save();
weapon2.Load();

Console.WriteLine($"Weapon 2 loaded from file, bullets = {weapon2.GetBullets()}");
