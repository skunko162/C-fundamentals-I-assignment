class Enemy 
{
    public string Name;
    public int Health = 100;
    public List<Attacks> AttackList;

    public Enemy (string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attacks>();
    }
    public Enemy (string name, int h)
    {
        Name = name;
        Health = h;
        AttackList = new List<Attacks>();
    }
    public Attacks randomAttack()
    {
        Random rand = new Random();
        int num = rand.Next(0,AttackList.Count);
        System.Console.WriteLine( $"{Name} used {AttackList[num].Name}");
        return this.AttackList[num];
    }
};