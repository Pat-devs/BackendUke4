class TagPrinter
{
    public static void Print(Tag tag) // prints a single tag
    {
        Console.WriteLine("Tag: #" + tag.Name);
    }

    public static void Print(List<Tag> tags) // prints a list of tags
    {
        Console.WriteLine("Tags: ");

        foreach(Tag tag in tags)
        {
            Console.WriteLine("Tag: #" + tag.Name);
        }
    }
}