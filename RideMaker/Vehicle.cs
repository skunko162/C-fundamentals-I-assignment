// Create a vehicle class with the following properties:

// A name (i.e. Honda Accord, Mountain Bike, Rollerblades)

// The number of passengers the vehicle carries

// What color is the vehicle

// Whether or not the vehicle has an engine

// The top speed the vehicle can reach

// How many miles the vehicle has already traveled - start this at 0

// A constructor that allows a user to fill in all fields (except distance traveled)

/* A constructor that only allows a user to fill in name and color and provides default 
values for all other fields */

// A method called ShowInfo() which prints out all the information about the vehicle

/* A method called Travel() which accepts input for distance, adds that distance to the 
total distance traveled, and prints out a message saying how far the vehicle has gone */

class Vehicle
{
    string name;
    int numberOfPassengers;
    string color;
    bool hasEngine;
    int topSpeed;
    int milesTravelled = 0;

    public Vehicle (string name, int numberOfPassengers, int topSpeed, string color, bool hasEngine = true)
    {
        this.name = name;
        this.numberOfPassengers = numberOfPassengers;
        this.color = color;
        this.hasEngine = hasEngine;
        this.topSpeed = topSpeed;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Make and Model: " + name + " Capacity: " + numberOfPassengers + " Color: " + color + " Engine: " + hasEngine + " TopSpeed " + topSpeed);
    }
}