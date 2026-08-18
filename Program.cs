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
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. List tags longer than 5 chars");
            Console.WriteLine("7. List tags that begin with c");
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
                running = false;
                Console.WriteLine("Byebye.");
            }
            else if (choice == 6)
            {
                // TagPrinter.Print(tagManager.GetLongTags()); 


                // List<Tag> filteredTags = tagManager.Filter(IsLongTag); // provide a named method as argument

                List<Tag> filteredTags = tagManager.Filter(
                    tag => tag.Name.Length > 5 // provide an anonymous function (if a lambda has only one line we can skip the {} and return keyword, return is implied)
                ); 
                
                
                TagPrinter.Print(filteredTags);
            }
            else if (choice == 7)
            {
                // TagPrinter.Print(tagManager.GetTagsStartingWithC());
                List<Tag> filteredTags = tagManager.Filter(StartsWithC);
                TagPrinter.Print(filteredTags);
            }
        }
    }
}