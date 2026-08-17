class TagService
{
    public List<TagModel> ParseTags(string input)
    {
        List<TagModel> tagsList = new List<TagModel>();

        string[] tagsArray = input.Split(",");

        foreach(string tagInput in tagsArray)
        {
            string cleanedTag = tagInput.Trim();
            
            // after cleaning we use the userdata to construct a new instance modelled after the TagModel class
            TagModel tag = new TagModel(cleanedTag);
            tagsList.Add(tag);
        }

        return tagsList;
    }
}