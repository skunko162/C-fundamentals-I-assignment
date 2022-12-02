int[] arr = {-4,-11,1,-3,2,-5,3,12,4,5,6};
List<int> IntList = new List<int> (arr);
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

Dictionary<string, string> iceCreamNames = new Dictionary<string, string>();
iceCreamNames.Add("Sandi", "Butter Peacon");
iceCreamNames.Add("Darla", "Mint Chip");
iceCreamNames.Add("Sara", "Cherry Cordial");
iceCreamNames.Add("Lara", "Chocolate Chip");

// 1. Iterate and print values
// Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)

static void PrintList(List<string> iceCream)
{
    foreach (string flavor in iceCream)
    {
    Console.WriteLine($"{flavor}");
    }
}
PrintList(iceCream);

// 2. Print Sum
// Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{
    int sum = IntList.Take(10).Sum();
    Console.WriteLine(sum);
}
SumOfNumbers(IntList);

// 3. Find Max
// Given a List of integers, find and return the largest value in the List.

static int FindMax(List<int> IntList)
{
    return IntList.Max();
}

Console.WriteLine(FindMax(IntList));

// 4. Square the Values
// Given a List of integers, return the List with all the values squared. (Hint: use your PrintList method to check that it worked!)

static List<int> SquareValues(List<int> IntList)
{
    for( int idx = 0; idx < IntList.Count; idx++)
    {          
        int square = IntList[idx]*IntList[idx];  
        IntList[idx] = square;
        Console.WriteLine(IntList[idx]);
    }
    return IntList;
}
SquareValues(IntList);

// 5. Replace Negative Numbers with 0
// Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] arr)
{
    for(int idx = 0; idx < arr.Length; idx++)
    {
        if (arr[idx] < 0)
        {
            int numBelowZero = arr[idx] - (arr[idx]);
            arr[idx] = numBelowZero;
        }
        Console.WriteLine(arr[idx]);
    }
    return arr;
}
NonNegatives(arr);

// 6. Print Dictionary
// Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string,string> iceCreamNames)
{
    foreach(KeyValuePair<string, string> key in iceCreamNames)
{
    Console.WriteLine(key);
}
}
PrintDictionary(iceCreamNames);

// 7. Find Key
// Given a search term, return true or false whether the given term is a key in a dictionary.

static bool FindKey(Dictionary<string,string> myDictionary, string SearchTerm)
{
    foreach(KeyValuePair<string,string> term in myDictionary)
    {
        if(SearchTerm == term.Key)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine(FindKey(iceCreamNames, "Sandi"));



// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
// 8. Generate a Dictionary

// Given a List of names and a List of integers, create a dictionary where the key is a name 
// from the List of names and the value is a number from the List of numbers. Assume that the 
// two Lists will be of the same length. Don't forget to print your results to make sure it worked.
List <string> NamesList = new List<string> () {"Julie", "Harold", "James", "Monica"};
List<int> AgesList = new List<int>() {6, 12, 7, 18};
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Ages)
{
    Dictionary<string, int> newDict = new Dictionary<string, int>();
    for(int i = 0; i < Names.Count; i ++){
        newDict.Add(Names[i], Ages[i]);
    
    }
    return newDict; 
}
Dictionary<string, int> newDict = GenerateDictionary(NamesList, AgesList);
foreach(KeyValuePair<string, int> entry in newDict)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}


