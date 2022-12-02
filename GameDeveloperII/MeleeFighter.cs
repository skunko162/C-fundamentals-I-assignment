class MeleeFighter : Enemy
{
    public MeleeFighter (string name) : base (name, 120)
    {
        Name = name;
        AttackList.Add (new Attacks ("Punch", 20, "basic", "physical"));
        AttackList.Add (new Attacks ("kick", 15, "basic", "physical"));
        AttackList.Add (new Attacks ("Tackle", 25, "intermediate", "physical"));
    }
    public Attacks randomAttackMelee()
    {
        Random rand = new Random();
        int num = rand.Next(0, AttackList.Count);
        AttackList[num].DamageDone += 10;
        System.Console.WriteLine($"{Name} used {AttackList[num].Name} and did 10 additional dmg for total of {AttackList[num].DamageDone}");
        return this.AttackList[num];
    }
        


}