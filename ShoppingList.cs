// Holds the items and takes care of loading and saving them.
class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;
    private int budget;
    public ShoppingList(string path, int budget)
    {
        this.path = path;
        this.budget = budget;
    }

    // Adds the item if it fits within the budget.
    // Returns false if the total would go over the budget.
    public bool Add(Item item)
    {
        if (Total() + item.Price > budget)
        {
            return false;
        }

        items.Add(item);
        return true;
    }

    // Removes the item the user sees as number 1, 2, 3 ...
    // Returns false if there is no item with that number.
    public bool RemoveAt(int number)
    {
        if (number < 1 || number > items.Count)
        {
            return false;
        }

        items.RemoveAt(number - 1);
        return true;
    }

    // Adds up the price of every item on the list. 

    public int Total()
    {
        int sum = 0;

        for (int i = 0; i < items.Count; i++)
        {
            sum += items[i].Price;
        }

        return sum;
    }

    // Looks up an item by its name. Returns null if there is no such item.
    public Item Find(string name)
    {
        foreach (Item item in items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }

        return null;
    }

    public void Print()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        Console.WriteLine($"Totalt: {Total()} kr");
    }

    // Writes one item per line, as "price;name".
    public void Save()
    {
        List<string> lines = new List<string>();

        foreach (Item item in items)
        {
            lines.Add($"{item.Price};{item.Name}");
        }
        try
        {
            File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n");
            Console.WriteLine("Listan är sparad.");
        }
        catch (IOException)
        {
            Console.WriteLine("Kunde inte spara listan. Filen är upptagen.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Kunde inte spara listan. Filen är skrivskyddad.");
        }
    }

    // Reads the file back into the list. Skips lines that cannot be read.
    public void Load()
    {
        if (!File.Exists(path))
        {
            return;
        }
        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            string[] parts = line.Split(';');
            if (parts.Length != 2)
            {
                continue;
            }
            if (!int.TryParse(parts[0], out int price))
            {
                continue;
            }
            try
            {
                items.Add(new Item(parts[1], price));
            }
            catch (ArgumentException)
            {
                // Skip lines with an empty name or a negative price.
            }
        }
    }
}