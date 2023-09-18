// Console.WriteLine("a" == "a"); //true
// Console.WriteLine("a" == "A"); //false
// Console.WriteLine(1 == 2); //fales

// string myValue = "a";
// Console.WriteLine(myValue == "a"); //true
// Console.WriteLine(myValue != "a"); //false
// Console.WriteLine("a" == "a "); //false cuz of the extra space


// string value1 = " all";
// string value2 = "ALL ";
// Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());

// //inequality operator

// string MyValue = "be yourself";
// Console.WriteLine(MyValue.ToUpper() != "be yourself"); //True

//use of inbuilt utility tasks from the string data type
// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

//using the negator operator !
// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine(!pangram.Contains("fox")); //False
// Console.WriteLine(!pangram.Contains("cow")); //True

//using the conditional operator ?:
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"discount : {discount}");

//can also be writen inline like below
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
