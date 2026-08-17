class TagManager
{
    // State: tags
    // Behavior: Add()
    private List<Tag> tags = new List<Tag>();
    public void Add(string name)
    {
        Tag tag = new Tag(name);
        tags.Add(tag);
    }
    public void AddMany(string input)
    {
        string[] tagsArray = input.Split(",");

        foreach (string tagInput in tagsArray)
        {
            Add(tagInput);
        }

    }
    public List<Tag> GetAll()
    {
        return tags;
    }
}