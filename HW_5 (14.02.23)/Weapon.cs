
    public class Weapon
    {
        private int shot_range = 0;
        private double caliber = 0;
        private int num_ball_store = 0;
        private int max_num_bullets_store = 0;

        public void Initialize(int range, double caliber, int maxSize)
        {
            if (range < 0) Console.WriteLine("Invalid range value!");
            if (caliber < 0) Console.WriteLine("Invalid caliber value!");
            if (maxSize < 0) Console.WriteLine("Invalid store size value!");

            this.shot_range = range;
            this.caliber = caliber;
            max_num_bullets_store = maxSize;
            num_ball_store = maxSize;
        }
        public bool Shot()
        {
            if (num_ball_store > 0)
            {
                num_ball_store--;
                return true;
            }
            else return false;
        }
        public void Recharge() => num_ball_store = max_num_bullets_store;
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter("weapon.txt"))
            {
                writer.WriteLine(shot_range);
                writer.WriteLine(caliber);
                writer.WriteLine(num_ball_store);
                writer.WriteLine(max_num_bullets_store);
            }
        }

        public void Load()
        {
            using (StreamReader reader = new StreamReader("weapon.txt"))
            {
                shot_range = int.Parse(reader.ReadLine());
                caliber = float.Parse(reader.ReadLine());
                num_ball_store = int.Parse(reader.ReadLine());
                max_num_bullets_store = int.Parse(reader.ReadLine());
            }
        }
        public int GetRange() { return shot_range; }
        public double GetCaliber() { return caliber; }
        public int GetBullets() { return num_ball_store; }
        public int GetMaxBullets() { return max_num_bullets_store;}

    }
