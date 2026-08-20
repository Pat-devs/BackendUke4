class TagRepository
{
    private string fileName = "tags.txt"; 

    public void Save(List<Tag> tagsList)
    {
        // before writning to the file we need convert the list of objects to a list of strings (Select)
        List<string> lines = tagsList.Select(tag => tag.Name).ToList();
        File.WriteAllLines(fileName, lines);
    }
    public List<Tag> Load()
    {

        if (!File.Exists(fileName)) return new List<Tag>(); // early return pattern allows us to terminate remainder of the methods code if the file does not exist.

        string[] savedTags = File.ReadAllLines(fileName);

        List<Tag> tagsList = savedTags.Select(line => new Tag(line)).ToList(); // Select transforms the array of strings into a list of Tag-objects

        //List<string> lines = new List<string>();
        //lines = new List<string>(savedTags);

        //foreach (string line in lines)
        //{
        //    Tag tag = new Tag(line);
        //    tagsList.Add(tag);
        //}

        return tagsList;
    }
}