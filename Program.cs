// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
int[] numArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".

string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values


bool[] altern = new bool[10];
bool value = true;
for (int i = 0; i < altern.Length; i++)
{
    altern[i] = value;
    value = !value;
    Console.WriteLine(altern[i]);
}



// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> flavors = new List<string>();
flavors.Add("chocolate chip");
flavors.Add("vanilla");
flavors.Add("chocolate");
flavors.Add("peanut butter");
flavors.Add("apple pie");

// Output the length of the List after you added the flavors.
Console.WriteLine(flavors.Count);

// Output the third flavor in the List.
System.Console.WriteLine(flavors[2]);

// Now remove the third flavor using its index location.

flavors.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.

System.Console.WriteLine(flavors.Count);




// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string, string> dict = new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)

// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random rando = new Random();
foreach (string name in names)
{
    int index = rando.Next(flavors.Count);
    string flavor = flavors[index];
    dict.Add(name, flavor);
}
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach (KeyValuePair<string, string> entry in dict)
{
    Console.WriteLine($"{entry.Key}, {entry.Value}");
}