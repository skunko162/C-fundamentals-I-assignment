// Create a dictionary where the keys are strings and the values are integers.
Dictionary<string, int> profile = new Dictionary<string, int>();
// Add a few entries. Don't worry about what to name your keys, anything will do for now.
profile.Add("toys", 52);
profile.Add("dogs", 25);
profile.Add("cats", 2);
// Loop through the dictionary to print out the values, but only print the value if the number is higher than 5.
foreach(KeyValuePair<string, int> entry in profile)
{
    if (entry.Value > 5 ){
        Console.WriteLine(entry.Value);   
    }
}

// What would happen if you tried to add a new entry that used an already existing key name? Test it out and make notes on what happened!


// Can you make a dictionary where the value is a List of integers?
Dictionary<int, List<string>> fileList = new Dictionary<int, List<string>>();
fileList.Add(101, new List<string> { "fijo", "Frigy" });
fileList.Add(102, new List<string> { "lijo", "liji" });
fileList.Add(103, new List<string> { "vimal", "vilma" });

for (int Key = 101; Key < 104; Key++)
{
    for (int ListIndex = 0; ListIndex < fileList[Key].Count; ListIndex++)
    {
       Console.WriteLine(fileList[Key][ListIndex] as string);
    }
}