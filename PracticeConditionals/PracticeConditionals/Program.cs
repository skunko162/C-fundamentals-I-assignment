
// Write a conditional in which you will only allow customers greater than or equal to 42 
// inches and shorter than 78 inches to get on a roller coaster.
int height = 58;

if (height >= 42 && height < 72) {
    Console.WriteLine("you can ride the Rollercoaster!");
} else {
    Console.WriteLine("Better luck next time");
}


// Write a conditional in which you check with a boolean whether an order has been completed. 
//Print out "Order complete!" if so and "Order is still in process" if not.
int Cost = 50;
int AmountPaid = 49; 
int RemainingOwed = Cost-AmountPaid;

if (Cost == AmountPaid) {
    Console.WriteLine("Thank you for your business!");
} else {
    Console.WriteLine("you have not paid enough! You owe {0} dollar!", RemainingOwed);
}

// Write a conditional in which you order your favorite drink (you pick the drink!). 
//If you receive the wrong drink, print out "I ordered [insert your favorite drink here]."
string DrinkOrdered = "Bud Light";
string DrinkReceived= "Bud Light";
int DrinkTemperature= 35;

if (DrinkOrdered != DrinkReceived) {
    Console.WriteLine("I ordered {0}", DrinkOrdered);
} else if (DrinkTemperature >= 34){
    Console.WriteLine("This Drink tastes like warm piss! I want a new one!");
}
else {
    Console.WriteLine("Thanks for the drink!");
}

// Bonus: Add to the above condition that if you receive the right drink but it is not in the right temperature range (hot or cold depending on your drink) then you send it back.

Random rand = new Random();
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(rand.NextDouble());
}

