namespace CatchUpPlatform.API.News.Domain.Model.Commands
{
    public record CreateFavoriteSource(string NewsApiKey, string SourceId) {
    }
}
