// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "A456";
// fraudulentOrderIDs[2] = "A789";
// // fraudulentOrderIDs[3] = "D000";

//initialize an array instead of all the above work do

// string[] fraudulentOrderIDs = {"A123", "A456", "A789"};

// //retrive values
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// //re-assign array values
// fraudulentOrderIDs[1] = "A001";
// Console.WriteLine($"Reassigned second: {fraudulentOrderIDs[1]}");

// //introduce .Length
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//implement the foreach statement
string[] namesof = {"effie", "njoki", "ngina"};
foreach (string n in namesof)
{
    Console.WriteLine(n);
}

//let's try with an array of int
int[] nums = {100, 200, 300, 400, 500};
//declare a new variable to get sum
int sum = 0;
//use bin to store the number of the bin whose value is currently being processed.
int bin = 0;
foreach (int i in nums)
{
    sum += i;
    bin++;
    Console.WriteLine($"Bin {bin} = {nums} items (Running total: {sum})");
}
//display sum
Console.WriteLine($"Total sum is: {sum}");

//nested iteration
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
