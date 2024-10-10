using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Application.Internal
{
    public class FavoriteSourceQueryService : IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> IFavoriteSourceQueryService.Handle(GetFavoriteSourceByIdQuery query)
        {
            throw new NotImplementedException();
        }

        Task<FavoriteSource?> IFavoriteSourceQueryService.Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
