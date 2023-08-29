// Arrays

// Part 1
int[] Nums = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
for (int i = 0; i < Nums.Length; i += 1)
    Console.WriteLine(Nums[i]);

// Part 2
string[] Names = { "Tim", "Martin", "Nikki", "Sara" };


// Part 3
bool[] Boolean = new bool[10];

for (var i = 0; i < 10; i++)
{   
    
    if( i % 2 == 0){
        // Starting with true
        Boolean[i] = true;
        
    }
    Console.WriteLine(Boolean[i]);
}


// List

// part 1
List<string> IceCream = new List<string>();
IceCream.Add("Chocolate");
IceCream.Add("Vanilla");
IceCream.Add("Cookies and Cream");
IceCream.Add("Cookie Dough");
IceCream.Add("Rocky Road");

// part 2
Console.WriteLine(IceCream.Count);
// part 3
Console.WriteLine(IceCream[2]);
// part 4
IceCream.RemoveAt(2);
// part 5
Console.WriteLine(IceCream.Count);


// Dictionaries

// part 1
Dictionary<string, string> Togther = new Dictionary<string, string>();
Random RandomType = new Random();

// part 2
Togther.Add(Names[0],IceCream[RandomType.Next(0,4)]);
Togther.Add(Names[1],IceCream[RandomType.Next(0,4)]);
Togther.Add(Names[2],IceCream[RandomType.Next(0,4)]);
Togther.Add(Names[3],IceCream[RandomType.Next(0,4)]);

// part 3
foreach (KeyValuePair<string,string> Name in Togther)
{
    Console.WriteLine($"{Name.Key}'s favorite ice cream is {Name.Value}");
}