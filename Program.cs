namespace BackendUke3;

class Program
{
    static bool IsLongTag(Tag tag)
    {
        return tag.Name.Length > 5; // coffee = 6
    }
    static bool StartsWithC(Tag tag)
    {
        return tag.Name.StartsWith("c");
    }
    static void Main(string[] args)
    {

        //Tag coffeeTag = new Tag("coffee");

        // var condtion = IsLongTag;

        //Func<Tag, bool> condition = IsLongTag; // a Func is basically a delegate

        //Console.WriteLine(condition(coffeeTag));


        //Console.ReadLine();


        // create an instance of the TagRepository
        TagRepository tagRepository = new TagRepository();
        // create an instance of the TagManager
        TagManager tagManager = new TagManager();

        // Tag printer UI:
        Console.Clear();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Tag manager menu");
            Console.WriteLine("1. Enter new tag(s)");
            Console.WriteLine("2. Show current tags");
            Console.WriteLine("3. Save tags to file");
            Console.WriteLine("4. Load tags from file");
            Console.WriteLine("5. List tags longer than 5 chars");
            Console.WriteLine("6. Search tags");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");

            int choice = 0;
            bool isInputValid = int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine("Enter a tag, or tags separated by comma");
                string userInputTags = Console.ReadLine(); // f.eks "Coffee" eller "tea, coffe, milk"
                tagManager.AddMany(userInputTags);
            }
            else if (choice == 2)
            {
                TagPrinter.Print(tagManager.GetAll());
            }
            else if (choice == 3)
            {
                Console.WriteLine("saving to file...");
                tagRepository.Save(tagManager.GetAll());
            }
            else if (choice == 4)
            {
                Console.WriteLine("loading from file...");
                
                List<Tag> loadedTags = tagRepository.Load();
                tagManager.ReplaceAll(loadedTags);
            }
            else if (choice == 5)
            {
                List<Tag> filteredTags = tagManager.Filter(tag => tag.Name.Length > 5); 
                TagPrinter.Print(filteredTags);

                //List<Tag> tags = tagManager.GetAll();

                //List<Tag> longTags = tags.Where(tag => tag.Name.StartsWith("W")).ToList();

                //TagPrinter.Print(longTags);
            }
            else if (choice == 6) // search
            {
                Console.Write("Enter search text: ");

                string searchText = Console.ReadLine();

                List<Tag> filteredTags = tagManager.Filter(tag => tag.Name.Contains(searchText)); // case sensitive
                
                TagPrinter.Print(filteredTags);
            }
            else if (choice == 7)
            {
                running = false;
                Console.WriteLine("Byebye.");
            }
        }
    }
}