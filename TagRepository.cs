class TagRepository
{
    private string fileName = "tags.txt"; 

    public void Save(List<Tag> tagsList)
    {
        
        // before writning to the file we need convert the list of objects to a list of strings

        List<string> lines = new List<string>();

        foreach (Tag tag in tagsList)
        {
            lines.Add(tag.Name);
        }

        File.WriteAllLines(fileName, lines);
    }
    public List<Tag> Load()
    {
        List<Tag> tagsList = new List<Tag>();

        if (File.Exists(fileName))
        {
            string[] savedTags = File.ReadAllLines(fileName);

            List<string> lines = new List<string>();
            lines = new List<string>(savedTags);

            foreach (string line in lines)
            {
                Tag tag = new Tag(line);
                tagsList.Add(tag);
            }
        }

        return tagsList;
    }
}