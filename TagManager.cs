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
}