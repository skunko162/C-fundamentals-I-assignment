Random rand = new Random();
// Three Basic Arrays
// Create an array with the integers 0 through 9 inside.
int [] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
// Create an array with the names "Tim", "Martin", "Nikki", and "Sara".
string [] arrNames = {"Tim", "Martin", "Nikki", "Sara"};
// Create an array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool [] arrTrueFalse = new bool [10];
for(int idx = 0; idx < arrTrueFalse.Length; idx ++)
{
    arrTrueFalse[idx]= idx % 2 == 0;
        Console.WriteLine(arrTrueFalse[idx]);
    }
// List of Flavors
// Create a List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCream = new List<string>();
iceCream.Add("Strawberry");
iceCream.Add("Mint Chip");
iceCream.Add("Moosetracks");
iceCream.Add("Grasshopper Pie");
iceCream.Add("Birthday Cake");
iceCream.Add("Butter Pecon");
iceCream.Add("Cherry Cordial");
iceCream.Add("Strawberry Rubarb");
iceCream.Add("Chocolate Chip");
iceCream.Add("Peanut butter");
// Output the length of the List after you added the flavors.
Console.WriteLine($"There are currently {iceCream.Count} ice cream flavors!");
// Output the third flavor in the List.
Console.WriteLine(iceCream[2]);
// Now remove the third flavor using its index location.
iceCream.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine($"There are currently {iceCream.Count} ice cream flavors!");
// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string, string> namesIceCream = new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array.


// Each value is a randomly selected flavor from your flavors List
foreach(string name in arrNames)
{
    int RandomIndexNum = rand.Next(0,4);
    string RandFlavor = iceCream[RandomIndexNum];
    namesIceCream.Add(name, RandFlavor);
};
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach(KeyValuePair<string, string> key in namesIceCream)
{
    Console.WriteLine(key);
}