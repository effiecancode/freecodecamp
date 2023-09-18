// In this challenge, you'll implement decision logic based on a series of business
//rules. The business rules specify the access that will be granted to users
//based on their role-based permissions and their career level.
//Code branches will display a different message to the user
//depending on their permissions and level.

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Super Admin User");
}
else
{
    Console.WriteLine("Welcome, Admin User");
}

else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}

else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

//Since all business logic requires some Boolean expressions,
//i've added a valuable tool to my programming toolbox.
