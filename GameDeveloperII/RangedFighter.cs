class RangedFighter : Enemy
{
    public int Distance;

    public RangedFighter (string name) : base(name)
    {
        Name = name;
        Distance = 5;
        AttackList.Add (new Attacks ("Shoot Arrow", 20, "basic", "physical"));
        AttackList.Add (new Attacks ("Throw Knife", 15, "basic", "physical"));
    }
    public Attacks? randomAttackRanged()
        {   if (Distance < 10 )
            {
                System.Console.WriteLine("you are too close!");
                return null;
            }
            Random rand = new Random();
            int num = rand.Next(0, AttackList.Count);
            System.Console.WriteLine($"{Name} used {AttackList[num].Name} and did {AttackList[num].DamageDone} damage!");
            return this.AttackList[num];
        }
    public void Dash()
        {
            Distance += 20;
            System.Console.WriteLine("Ranged Fighter has Dashed 20 yards away");
        }
    }  