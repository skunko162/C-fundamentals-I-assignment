// Health starts at a default of 80
// Attacks:
// Fireball, 25 damage
// Shield, 0 damage
// Staff Strike, 15 damage
/*Heal method - The fighter heals a targeted Enemy character for 40 health 
and displays the new health at the end*/




class MagicCaster : Enemy
{   
    public MagicCaster (string name) : base (name, 80)
    {
        Name= name;
        AttackList.Add (new Attacks ("Fireball", 25, "intermediate", "Fire"));
        AttackList.Add (new Attacks ("Shield", 0, "intermediate", "Protective Magic"));
        AttackList.Add (new Attacks ("Staff Strike", 15, "basic", "physical"));
    }
    public Attacks RandomAttackMagic()
    {
        Random rand = new Random();
        int num = rand.Next(0, AttackList.Count);
        AttackList[num].DamageDone += 10;
        System.Console.WriteLine($"{Name} used {AttackList[num].Name} and did 10 additional dmg for total of {AttackList[num].DamageDone}");
        return this.AttackList[num];
    }

    public void Heal(Enemy t)
    {
        t.Health += 40;
        System.Console.WriteLine($"you have healed {t.Name} to {t.Health}!");
    }
}