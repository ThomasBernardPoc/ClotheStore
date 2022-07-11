using System.Text.Json.Serialization;

namespace ClotheStore.Models.DTOs
{
    public class Brand
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("channelExclusions")]
        public List<object> ChannelExclusions { get; set; }

        [JsonPropertyName("webLargePriority")]
        public int WebLargePriority { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("style")]
        public Style Style { get; set; }

        [JsonPropertyName("link")]
        public object Link { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }

    public class Child
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("channelExclusions")]
        public List<string> ChannelExclusions { get; set; }

        [JsonPropertyName("webLargePriority")]
        public int WebLargePriority { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("style")]
        public Style Style { get; set; }

        [JsonPropertyName("link")]
        public object Link { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }

    public class Content
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("subTitle")]
        public object SubTitle { get; set; }

        [JsonPropertyName("webLargeImageUrl")]
        public object WebLargeImageUrl { get; set; }

        [JsonPropertyName("mobileImageUrl")]
        public object MobileImageUrl { get; set; }
    }

    public class Display
    {
        [JsonPropertyName("webLargeTemplateId")]
        public int WebLargeTemplateId { get; set; }

        [JsonPropertyName("webLargeTemplateName")]
        public string WebLargeTemplateName { get; set; }

        [JsonPropertyName("webLargeColumnSpan")]
        public int WebLargeColumnSpan { get; set; }

        [JsonPropertyName("mobileTemplateId")]
        public int MobileTemplateId { get; set; }

        [JsonPropertyName("mobileTemplateName")]
        public string MobileTemplateName { get; set; }

        [JsonPropertyName("mobileDisplayLayout")]
        public string MobileDisplayLayout { get; set; }
    }

    public class Footer
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("alias")]
        public object Alias { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("channelExclusions")]
        public List<object> ChannelExclusions { get; set; }

        [JsonPropertyName("webLargePriority")]
        public int WebLargePriority { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("style")]
        public Style Style { get; set; }

        [JsonPropertyName("link")]
        public object Link { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("linkType")]
        public string LinkType { get; set; }

        [JsonPropertyName("brandSectionAlias")]
        public object BrandSectionAlias { get; set; }

        [JsonPropertyName("categoryId")]
        public object CategoryId { get; set; }

        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }

        [JsonPropertyName("appUrl")]
        public object AppUrl { get; set; }
    }

    public class Navigation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("channelExclusions")]
        public List<object> ChannelExclusions { get; set; }

        [JsonPropertyName("webLargePriority")]
        public int WebLargePriority { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

        [JsonPropertyName("display")]
        public object Display { get; set; }

        [JsonPropertyName("style")]
        public Style Style { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }

    public class RapidApiCategoriesDtoDown
    {
        [JsonPropertyName("navigation")]
        public List<Navigation> Navigation { get; set; }

        [JsonPropertyName("brands")]
        public List<Brand> Brands { get; set; }

        [JsonPropertyName("footer")]
        public List<Footer> Footer { get; set; }
    }

    public class Style
    {
        [JsonPropertyName("webLargeStyleType")]
        public string WebLargeStyleType { get; set; }

        [JsonPropertyName("mobileStyleType")]
        public string MobileStyleType { get; set; }
    }
}
