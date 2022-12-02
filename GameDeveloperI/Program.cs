//attack instances
Attack attack1 = new Attack("Whirlwind Kick", 10, "Basic", "Wind");
Attack attack2 = new Attack("Breath of Fire", 15, "Intermediate", "Fire");
Attack attack3 = new Attack("EarthQuake", 15, "Fininhing Move", "Earth");

//instance of enemy 
Enemy enemy1 = new Enemy("Belthazar");
enemy1.AttackList.Add(attack1);
enemy1.AttackList.Add(attack2);
enemy1.AttackList.Add(attack3);

enemy1.randomAttack();