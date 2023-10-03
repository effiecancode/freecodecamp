// basic switch statement structure

// switch(fruit)
// {
//     case "apple";
//         Console.WriteLine($"App will display information for apple.");
//         break;
//     case "banana";
//         Console.WriteLine($"App will display information for banana.");
//         break;
//     case "cherry";
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }
// The match expression/ switch expression is the value following the switch keyword, in this case (fruit)
// Each switch section is defined by a case pattern
// Case patterns are constructed using the keyword case

// int employeelevel = 400;
// string employeename = "js";

// string title = "";

// switch (employeelevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeename}, {title}");


// SWITCH STATEMENT CHALLENGE
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
