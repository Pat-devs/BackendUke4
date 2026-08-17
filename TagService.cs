class TagService
{
    public List<Tag> ParseTags(string input)
    {
        List<Tag> tagsList = new List<Tag>();

        string[] tagsArray = input.Split(",");

        foreach(string tagInput in tagsArray)
        {
            string cleanedTag = tagInput.Trim();
            
            // after cleaning we use the userdata to construct a new instance modelled after the Tag class
            Tag tag = new Tag(cleanedTag);
            tagsList.Add(tag);
        }

        return tagsList;
    }
}