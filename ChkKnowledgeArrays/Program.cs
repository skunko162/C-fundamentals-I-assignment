// Create an array of integers that will hold 8 values. (Do not fill in the values, just create 8 slots.)
int[] numArray = new int[8];
// Place the number 17 in the third spot of your array. (Think carefully about the index number you need to make this happen!)
numArray[2]= 17;
Console.WriteLine($"The third number of the Arr is {numArray[2]}");
// Try to place the word "Hello" in the fifth spot. What happens?
// numArray[6]= "Hello";
// Loop through your array and print out the values.
foreach (int num in numArray){
    Console.WriteLine(num);
}
// If you did the above action with a for loop, do it again but with a foreach loop.
for (int idx = 0; idx < numArray.Length; idx++){
    Console.WriteLine(numArray[idx]);
}
// Try to Console.WriteLine your array. What result do you get? Weird, right? Do a bit of research on this to find out why it happens and how to work around it!
Console.WriteLine(numArray);