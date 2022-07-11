using System.Text.Json.Serialization;

namespace ClotheStore.Models.DTOs
{
    public class Content
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class Navigation
    {
        [JsonPropertyName("content")]
        public Content Content { get; set; }
    }

    public class RapidApiCategoriesDtoDown
    {
        [JsonPropertyName("navigation")]
        public List<Navigation> Navigation { get; set; }
    }
}
