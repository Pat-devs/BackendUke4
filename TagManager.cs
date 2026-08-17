class TagManager
{
    // State: tags
    // Behavior: Add(), GetAllTags(), ReplaceAll()
    private List<Tag> tags = new List<Tag>();
    private bool Contains(string name)
    {
        foreach (Tag tag in tags)
        {
            if (tag.Name == name) return true;
        }

        return false;
    }
    public void Add(string name)
    {
        if (Contains(name)) return;

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
    public void ReplaceAll(List<Tag> loadedTags)
    {
        tags.Clear();
        foreach (Tag tag in loadedTags)
        {
            Add(tag.Name);
        }
    }
}