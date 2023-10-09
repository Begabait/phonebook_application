Phonebook numbers = new Phonebook();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("What would you like to do in the phonebook?\nfor adding a number type 'a'\nfor checking a number type 'c'\nfor deleting a number type 'd'\ntype 'q' to quit\n");
    Console.ResetColor();
    string answer = Console.ReadLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;

    if (answer == "a")
    {
        numbers.add_number();
    }
    else if (answer == "c")
    {
        numbers.print_all();
        numbers.check_number();
    }
    else if (answer == "d")
    {
        numbers.remove_number();
    }
    else if (answer == "q")
    {
        Console.WriteLine("See ya later!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong input, please try again\n");
    }
}

public class Phonebook
{
    private Dictionary<string, string> phonebook = new Dictionary<string, string>();

    public Phonebook() { }

    public void add_number()
    {
        Console.WriteLine("What number would you like to add?");
        string number = Console.ReadLine();
        if (phonebook.Keys.Contains(number))
        {
            Console.WriteLine($"Sorry, this number already exists and it belongs to {phonebook[number]}\n");
        }
        else
        {
            Console.WriteLine("What is the name of the person with that number?");
            string name = Console.ReadLine();
            phonebook.Add(number, name);
            Console.WriteLine("Number added.\n");
        }
    }

    public void print_all()
    {
        Console.WriteLine("Here, you can take a look at all the numbers:\n");
        foreach (KeyValuePair<string, string> item in phonebook)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }
    }

    public void check_number()
    {
        Console.WriteLine("\nWhich number would you like to check for?");
        string number = Console.ReadLine();
        phonebook.TryGetValue(number, out string output);
        if (output != null)
        {
            Console.WriteLine("Yes, there is a number, and the name is " + output + "\n");
        }
        else
        {
            Console.WriteLine("Sorry, there is no number like that.\n");
        }
    }

    public void remove_number()
    {
        Console.WriteLine("Which number would you like to remove?");
        string number = Console.ReadLine();
        phonebook.Remove(number);
        Console.WriteLine("Number deleted.\n");
    }
}