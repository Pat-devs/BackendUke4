class TagPrinter
{
    public static void Print(TagModel tag) // prints a single tag
    {
        Console.WriteLine("Tag: #" + tag.Name);
    }

    public static void Print(List<TagModel> tags) // prints a list of tags
    {
        Console.WriteLine("Tags: ");

        foreach(TagModel tag in tags)
        {
            Console.WriteLine("Tag: #" + tag.Name);
        }
    }
}