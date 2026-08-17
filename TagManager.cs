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
        // we return a copy of the tags list instead of returning the tags list itself to avoid potential issues. 
        return new List<Tag>(tags);
    }
}