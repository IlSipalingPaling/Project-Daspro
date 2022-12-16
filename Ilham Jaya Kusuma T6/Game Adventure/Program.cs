using System;

namespace Game_Adventure
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Selamat datang di Game Adventure");
            System.Console.WriteLine("Siapakah nama anda?");
            Novice Player = new Novice();
            Player.Name = Console.ReadLine();
            System.Console.WriteLine($"{Player.Name} apakah anda siap untuk berpetualang?\n(y/n)");
            string bReady = Console.ReadLine();
            if (bReady == "y")
            {
                System.Console.WriteLine("Anda mulai berpetualang...");
                Enemy enemy1 = new Enemy("Vampire");
                System.Console.WriteLine($"Anda berpapasan dengan {enemy1.Name}");
                System.Console.WriteLine($"{enemy1.Name} menyerang anda...");
                System.Console.WriteLine("Pilih aksi yang akan anda lakukan");
                System.Console.WriteLine("1. Serangan biasa");
                System.Console.WriteLine("2. Swing");
                System.Console.WriteLine("3. Istirahat");
                System.Console.WriteLine("4. Kabur");

                while (!Player.IsDead || !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                            System.Console.WriteLine($"{Player.Name} melakukan single attack");
                            enemy1.GetHit(Player.AttackPower);
                            Player.Experience += 0.3f;
                            enemy1.Attack(enemy1.AttackPower);
                            Player.GetHit(enemy1.AttackPower);
                            System.Console.WriteLine($"{Player.Name} darah: {Player.Health}\n{enemy1.Name} darah: {enemy1.Health}");
                            break;

                        case "2":
                            Player.Swing();
                            Player.Experience += 0.9f;
                            enemy1.GetHit(Player.AttackPower);
                            enemy1.Attack(enemy1.AttackPower);
                            Player.GetHit(enemy1.AttackPower);
                            System.Console.WriteLine($"{Player.Name} darah: {Player.Health}\n{enemy1.Name} darah: {enemy1.Health}");
                            break;

                        case "3":
                            Player.Rest();
                            System.Console.WriteLine("Energi sedang dipulihkan...");
                            enemy1.Attack(enemy1.AttackPower);
                            Player.GetHit(enemy1.AttackPower);
                            System.Console.WriteLine($"{Player.Name} darah: {Player.Health}\n{enemy1.Name} darah: {enemy1.Health}");
                            break;

                        case "4":
                            System.Console.WriteLine($"{Player.Name} melarikan diri...");
                            break;
                    }
                    if (Player.IsDead)
                    {
                        System.Console.WriteLine("Anda kalah...");
                        break;
                    }
                    else if (enemy1.IsDead)
                    {
                        System.Console.WriteLine("Anda menang!!!");
                        break;
                    }

                }
                System.Console.WriteLine($"Poin Exp yang didapatkan {Player.Experience}");
                System.Console.WriteLine("Petualangan berakhir...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
class Novice
{
    public int Health { get; set; }
    public string Name { get; set; }
    public int AttackPower { get; set; }
    public int Skillshot { get; set; }
    public bool IsDead { get; set; }
    public float Experience { get; set; }
    Random rnd = new Random();
    public Novice()
    {
        Health = 100;
        Skillshot = 0;
        AttackPower = 1;
        IsDead = false;
        Experience = 0f;
        Name = "Newbie";
    }
    public void Swing()
    {
        if (Skillshot > 0)
        {
            System.Console.WriteLine("SWING!!!");
            AttackPower = AttackPower + rnd.Next(3, 11);
            Skillshot--;
        }
        else
        {
            System.Console.WriteLine("Anda tidak memiliki energi yang cukup");
        }
    }
    public void GetHit(int HitValue)
    {
        System.Console.WriteLine($"{Name} terkena damage sebesar {HitValue}");
        Health = Health - HitValue;
        if (Health <= 0)
        {
            Health = 0;
            Die();
        }
    }
    public void Rest()
    {
        Skillshot = 3;
        AttackPower = 1;
    }
    public void Die()
    {
        System.Console.WriteLine("Kamu mati, Game Over...");
        IsDead = true;
    }
}
class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public bool IsDead { get; set; }
    Random rnd = new Random();
    public Enemy(string name)
    {
        Health = 75;
        Name = name;
    }
    public void Attack(int damage)
    {
        AttackPower = rnd.Next(3, 11);
    }
    public void GetHit(int HitValue)
    {
        System.Console.WriteLine($"{Name} terkena damage sebesar {HitValue}");
        Health = Health - HitValue;

        if (Health <= 0)
        {
            Health = 0;
            Die();
        }
    }
    public void Die()
    {
        System.Console.WriteLine($"{Name} mati");
        IsDead = true;
    }
}
