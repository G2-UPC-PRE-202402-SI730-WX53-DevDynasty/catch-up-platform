namespace CatchUpPlatform.API.News.Domain.Model.Commands;

public record UpdateFavoriteSourceCommand(int id, string NewsApiKey, string Sourceid);