using CatchUpPlatform.API.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.API.News.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<IFavoriteSource?> Handle(GetFavoriteSourceByIdQuery)
    }
}
