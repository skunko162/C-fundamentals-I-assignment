class Enemy 
{
    public string Name;
    public int Health = 100;
    public List<Attack> AttackList;

    public Enemy (string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }
    public Attack randomAttack()
    {
        Random rand = new Random();
        int num = rand.Next(0,AttackList.Count);
        System.Console.WriteLine( $"{Name} used {AttackList[num].Name}");
        return this.AttackList[num];
    }
};