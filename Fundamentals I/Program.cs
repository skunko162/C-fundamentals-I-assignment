

// Create a loop that prints all values from 1-255.
// for (int i = 1; i <= 255; i ++) {
//     Console.WriteLine( i );
// }

// Create a new loop that generates 5 random numbers between 10 and 20 and print out the sum of these values.

            Random r = new Random();
            int number = r.Next(10, 20); //r.Next() finds the next random # bet 10 and 20
            int numberTotal = number;  //declaring the variable "numberTotal" for the sum 
            numberTotal += number;                //the sum increases by new number with each pass
            int i = 1;            //i is the index counter
            for (i = 1; i <= 5; i++)  //the program will run through 5 iterations
                Console.WriteLine(r.Next(10, 20)); //program prints the next random #
                numberTotal += number; //need to keep a running sum of the numbers found
            Console.WriteLine("The sum is: {0}", numberTotal);

// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
// class Program
// {
//     
//     {
//         //
//         // Prints every tenth number from 0 to 200.
//         // Includes the first iteration.
//         //
//         for (int i = 0; i < 100; i++)
//         {
//             if ((i % 3) == 0 || (i % 5) ==0 )
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }
// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
    // class FizzBuzz
    // {
    //     static void Main(){
    //         for(int i = 0; i < 100; i++){
    //             if ((i % 3) == 0 ){
    //                 Console.WriteLine("fizz");
    //             }else if ((i % 5 ) == 0 ) {
    //                 Console.WriteLine("Buzz");
    //             } else {
    //                 Console.WriteLine(i);
    //             }
    //         }
    //     }
    // }

// // Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
// for(int i = 0; i < 100; i ++){
//     if ((i % 5 ) == 0 && (i % 3 == 0)) {
//         Console.WriteLine("FizzBuzz");
//     } else if ((i % 3) == 0 ){
//         Console.WriteLine("fizz");
//     }else if ((i % 5 ) == 0 ) {
//         Console.WriteLine("Buzz");
//     } else {
//         Console.WriteLine(i);
//     }
// }

// (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!





