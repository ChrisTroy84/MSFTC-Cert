Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


/*
    Some data types have methods that perform helpful utility tasks. 
    The String data type has many of these. Several return a Boolean value 
    including Contains(), StartsWith(), and EndsWith(). You can learn more 
    about them in the Microsoft Learn module "Manipulate alphanumeric data 
    using String class methods in C#".
*/

 
    string pangram = "The quick brown fox jumps over the lazy dog";
    Console.WriteLine(pangram.Contains("fox"));
    Console.WriteLine(pangram.Contains("cow"));

    // These two lines of code will create the same output
    Console.WriteLine(pangram.Contains("fox") == false);
    Console.WriteLine(!pangram.Contains("fox"));


    Console.WriteLine(!pangram.Contains("fox"));
    Console.WriteLine(!pangram.Contains("cow"));


int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


//Challenge activity:
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//challenge activity:
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
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