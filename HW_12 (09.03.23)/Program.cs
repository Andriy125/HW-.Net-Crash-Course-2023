using HW_12__09._03._23_;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

static CombatVehicle[] CreateArmy()
{
    Random rnd = new Random();
    int armySize = rnd.Next(5, 11);

    CombatVehicle[] army = new CombatVehicle[armySize];
    for (int i = 0; i < armySize; i++)
    {
        int vehicleType = rnd.Next(1, 4);
        string model = "" + (i + 1);

        switch (vehicleType)
        {
            case 1:
                army[i] = new Tank(model);
                break;
            case 2:
                army[i] = new ArmoredCar(model);
                break;
            case 3:
                army[i] = new AirDefenseVehicle(model);
                break;
        }
    }

    return army;
}

static CombatVehicle ChooseRandomVehicle(CombatVehicle[] army)
{
    Random rnd = new Random();
    return army[rnd.Next(army.Length)];
}

static bool HasVehiclesLeft(CombatVehicle[] army)
{
    return army.Any(vehicle => !vehicle.IsDestroyed());
}

void Round(CombatVehicle bm1, CombatVehicle bm2)
{
    Random rnd = new Random();
    int first = rnd.Next(1, 3); // Визначаємо, яка з БМ атакує першою (1 - bm1, 2 - bm2)
    int round = 1;

    while (!bm1.IsDestroyed() && !bm2.IsDestroyed())
    {
        Console.WriteLine($"Раунд {round}:");
        if (first == 1)
        {
            Console.WriteLine($">>>Атакує БМ-1 ({bm1.type}, модель {bm1.model}): \nУдар задано:");
            bm2.Defense(bm1.Attack());
            bm2.ShowInfo();

            Console.WriteLine($"\n>>>Атакує БМ-2 ({bm2.type}, модель {bm2.model}): \nУдар задано:");
            bm1.Defense(bm2.Attack());
            bm1.ShowInfo();
        }
        else
        {
            Console.WriteLine($">>>Атакує БМ-2 ({bm2.type}, модель {bm2.model}): \nУдар задано:");
            bm1.Defense(bm2.Attack());
            bm1.ShowInfo();

            Console.WriteLine($"\n>>>Атакує БМ-1 ({bm1.type}, модель {bm1.model}): \nУдар задано:");
            bm2.Defense(bm1.Attack());
            bm2.ShowInfo();
        }
        round++;
        Console.WriteLine();
    }

    bool bm1Wins = !bm1.IsDestroyed();
    Console.WriteLine(bm1Wins ? $"БМ-1 ({bm1.type}, модель {bm1.model}) перемогла!" : $"БМ-2 ({bm2.type}, модель {bm2.model}) перемогла!");
    //return bm1Wins;

}

CombatVehicle[] army1 = CreateArmy();
CombatVehicle[] army2 = CreateArmy();

Console.WriteLine("Битва починається!");

while (HasVehiclesLeft(army1) && HasVehiclesLeft(army2))
{
    CombatVehicle vehicle1 = ChooseRandomVehicle(army1);
    CombatVehicle vehicle2 = ChooseRandomVehicle(army2);
    Round(vehicle1, vehicle2);
    Console.WriteLine(new string('-',100));
    Console.WriteLine();
}

Console.WriteLine(!HasVehiclesLeft(army1) ? "Перше військо програло! Друге військо перемогло!" : "Друге військо програло! Перше військо перемогло!");





